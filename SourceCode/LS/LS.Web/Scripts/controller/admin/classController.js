/// <reference path="../../admin/plugins/jquery-ui-timepicker-addon/jquery-ui-timepicker-addon.min.js" />
/// <reference path="../../admin/plugins/jquery-ui-timepicker-addon/jquery-ui-timepicker-addon.min.js" />
//
//  Dynamically load  jQuery Timepicker plugin
//  homepage: http://trentrichardson.com/examples/timepicker/
//
function LoadTimePickerScript(callback) {
    if (!$.fn.timepicker) {
        $.getScript('Scripts/admin/plugins/jquery-ui-timepicker-addon/jquery-ui-timepicker-addon.min.js', callback);
    }

    else {
        if (callback && typeof (callback) === "function") {
            callback();
        }
    }
}

/*-------------------------------------------
	Function for jQuery-UI page (ui_jquery-ui.html)
---------------------------------------------*/
//
// Function for make all Date-Time pickers on page
//
function AllTimePickers() {
    $('#datetime_example').datetimepicker({});
    $('#time_example').timepicker({
        hourGrid: 4,
        minuteGrid: 10,
        timeFormat: 'hh:mm tt'
    });
    $('#date3_example').datepicker({ numberOfMonths: 3, showButtonPanel: true });
    $('#date3-1_example').datepicker({ numberOfMonths: 3, showButtonPanel: true });
    $('#date_example').datepicker({});
}

//
//  Dynamically load DataTables plugin
//  homepage: http://datatables.net v1.9.4 license - GPL or BSD
//
function LoadDataTablesScripts(callback) {
    function LoadDatatables() {
        $.getScript('Scripts/admin/plugins/datatables/jquery.dataTables.js', function () {
            $.getScript('Scripts/admin/plugins/datatables/ZeroClipboard.js', function () {
                $.getScript('Scripts/admin/plugins/datatables/TableTools.js', function () {
                    $.getScript('Scripts/admin/plugins/datatables/dataTables.bootstrap.js', callback);
                });
            });
        });
    }
    if (!$.fn.dataTables) {
        LoadDatatables();
    }
    else {
        if (callback && typeof (callback) === "function") {
            callback();
        }
    }
}

function TestTable1() {
    $('#datatable-1').dataTable({
        "aaSorting": [[0, "asc"]],
        "sDom": "<'box-content'<'col-sm-6'f><'col-sm-6 text-right'l><'clearfix'>>rt<'box-content'<'col-sm-6'i><'col-sm-6 text-right'p><'clearfix'>>",
        "sPaginationType": "bootstrap",
        "oLanguage": {
            "sSearch": "",
            "sLengthMenu": '_MENU_'
        }
    });
}
//
// Function for table, located in element with id = datatable-2
//
function TestTable2() {
    var asInitVals = [];
    var oTable = $('#datatable-2').dataTable({
        "aaSorting": [[0, "asc"]],
        "sDom": "<'box-content'<'col-sm-6'f><'col-sm-6 text-right'l><'clearfix'>>rt<'box-content'<'col-sm-6'i><'col-sm-6 text-right'p><'clearfix'>>",
        "sPaginationType": "bootstrap",
        "oLanguage": {
            "sSearch": "",
            "sLengthMenu": '_MENU_'
        },
        bAutoWidth: false
    });
    var header_inputs = $("#datatable-2 thead input");
    header_inputs.on('keyup', function () {
        /* Filter on the column (the index) of this element */
        oTable.fnFilter(this.value, header_inputs.index(this));
    })
	.on('focus', function () {
	    if (this.className == "search_init") {
	        this.className = "";
	        this.value = "";
	    }
	})
	.on('blur', function (i) {
	    if (this.value == "") {
	        this.className = "search_init";
	        this.value = asInitVals[header_inputs.index(this)];
	    }
	});
    header_inputs.each(function (i) {
        asInitVals[i] = this.value;
    });
}
//
// Function for table, located in element with id = datatable-3
//
function TestTable3() {
    $('#datatable-3').dataTable({
        "aaSorting": [[0, "asc"]],
        "sDom": "T<'box-content'<'col-sm-6'f><'col-sm-6 text-right'l><'clearfix'>>rt<'box-content'<'col-sm-6'i><'col-sm-6 text-right'p><'clearfix'>>",
        "sPaginationType": "bootstrap",
        "oLanguage": {
            "sSearch": "",
            "sLengthMenu": '_MENU_'
        },
        "oTableTools": {
            "sSwfPath": "Scripts/admin/plugins/datatables/copy_csv_xls_pdf.swf",
            "aButtons": [
				"copy",
				"print",
				{
				    "sExtends": "collection",
				    "sButtonText": 'Save <span class="caret" />',
				    "aButtons": ["csv", "xls", "pdf"]
				}
            ]
        }
    });
}

//
//  Dynamically load jQuery Select2 plugin
//  homepage: https://github.com/ivaynberg/select2  v3.4.5  license - GPL2
//
function LoadSelect2Script(callback) {
    if (!$.fn.select2) {
        $.getScript('Scripts/admin/plugins/select2/select2.min.js', callback);
    }
    else {
        if (callback && typeof (callback) === "function") {
            callback();
        }
    }
}

function WinMove() {
    $("div.box").not('.no-drop')
		.draggable({
		    revert: true,
		    zIndex: 2000,
		    cursor: "crosshair",
		    handle: '.box-name',
		    opacity: 0.8
		})
		.droppable({
		    tolerance: 'pointer',
		    drop: function (event, ui) {
		        var draggable = ui.draggable;
		        var droppable = $(this);
		        var dragPos = draggable.position();
		        var dropPos = droppable.position();
		        draggable.swap(droppable);
		        setTimeout(function () {
		            var dropmap = droppable.find('[id^=map-]');
		            var dragmap = draggable.find('[id^=map-]');
		            if (dragmap.length > 0 || dropmap.length > 0) {
		                dragmap.resize();
		                dropmap.resize();
		            }
		            else {
		                draggable.resize();
		                droppable.resize();
		            }
		        }, 50);
		        setTimeout(function () {
		            draggable.find('[id^=map-]').resize();
		            droppable.find('[id^=map-]').resize();
		        }, 250);
		    }
		});
}

function textSummary(text) {
    if (text.length > 100) {
        var summary = text.substr(0, 100) + "...";
        return summary;
    }
    return text;
}