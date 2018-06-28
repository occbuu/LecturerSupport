//Begin - Load LessonReferences

function loadDocLE(classId, type) {
    $('#ulLessonExtension').empty();

    var classId = [classId];
    var data = {
        ClassId: classId,
        Type: type,
    };

    $.ajax({
        url: '/Class/SearchLessonBySelectedLsit',
        type: 'Post',
        dataType: 'Json',
        data: { model: JSON.stringify(data), pageNumber: pageLEConfig.pageIndex, pageSize: pageLEConfig.pageSize },
        success: function (response) {
            if (response.status) {
                $('#scriptLessonExtension').tmpl(response.listClass).appendTo('#ulLessonExtension');
                if (response.total > pageLEConfig.pageSize) {
                    pagingLE(response.total, function () {
                        loadDocLE();
                    });
                }
            }
        },
        async: false
    });
}

function loadDocLR(classId, type) {
    $('#ulLessonReferences').empty();

    var classId = [classId];
    var data = {
        ClassId: classId,
        Type: type,
    };

    $.ajax({
        url: '/Class/SearchLessonBySelectedLsit',
        type: 'Post',
        dataType: 'Json',
        data: { model: JSON.stringify(data), pageNumber: pageLRConfig.pageIndex, pageSize: pageLRConfig.pageSize },
        success: function (response) {
            if (response.status) {
                $('#scriptLessonReferences').tmpl(response.listClass).appendTo('#ulLessonReferences');
                if (response.total > pageLRConfig.pageSize) {
                    pagingLR(response.total, function () {
                        loadDocLR();
                    });
                }
            }
        },
        async: false
    });
}

function loadDocLP(classId, type) {
    $('#ulLessonPrimary').empty();

    var classId = [classId];
    var data = {
        ClassId: classId,
        Type: type,
    };

    $.ajax({
        url: '/Class/SearchLessonBySelectedLsit',
        type: 'Post',
        dataType: 'Json',
        data: { model: JSON.stringify(data), pageNumber: pageConfig.pageIndex, pageSize: pageConfig.pageSize },
        success: function (response) {
            if (response.status) {
                $('#scriptLessonPrimary').tmpl(response.listClass).appendTo('#ulLessonPrimary');
                if (response.total > pageConfig.pageSize) {
                    paging(response.total, function () {
                        loadDocLP();
                    });
                }
            }
        },
        async: false
    });
}

//End

//Begin - Load Conspectus

function loadDocCR(classId, type) {
    $('#ulConspectusReferences').empty();

    var classId = [classId];
    var data = {
        ClassId: classId,
        Type: type,
    };

    $.ajax({
        url: '/Class/SearchConspectusBySelectedLsit',
        type: 'Post',
        dataType: 'Json',
        data: { model: JSON.stringify(data), pageNumber: pageCRConfig.pageIndex, pageSize: pageCRConfig.pageSize },
        success: function (response) {
            if (response.status) {
                $('#scriptConspectusReferences').tmpl(response.listClass).appendTo('#ulConspectusReferences');
                if (response.total > pageCRConfig.pageSize) {
                    pagingCR(response.total, function () {
                        loadDocCR();
                    });
                }
            }
        },
        async: false
    });
}

function loadDocCP(classId, type) {
    $('#ulConspectusPrimary').empty();

    var classId = [classId];
    var data = {
        ClassId: classId,
        Type: type,
    };

    $.ajax({
        url: '/Class/SearchConspectusBySelectedLsit',
        type: 'Post',
        dataType: 'Json',
        data: { model: JSON.stringify(data), pageNumber: pageCPConfig.pageIndex, pageSize: pageCPConfig.pageSize },
        success: function (response) {
            if (response.status) {
                $('#scriptConspectusPrimary').tmpl(response.listClass).appendTo('#ulConspectusPrimary');
                if (response.total > pageCPConfig.pageSize) {
                    pagingCP(response.total, function () {
                        loadDocCP();
                    });
                }
            }
        },
        async: false
    });
}

//End

//Begin - Load Exercise

function loadDocEO(classId, type) {
    $('#ulExerciseObligatory').empty();

    var classId = [classId];
    var data = {
        ClassId: classId,
        Type: type,
    };

    $.ajax({
        url: '/Class/SearchExerciseBySelectedLsit',
        type: 'Post',
        dataType: 'Json',
        data: { model: JSON.stringify(data), pageNumber: pageEOConfig.pageIndex, pageSize: pageEOConfig.pageSize },
        success: function (response) {
            if (response.status) {
                $('#scriptExerciseObligatory').tmpl(response.listClass).appendTo('#ulExerciseObligatory');
                if (response.total > pageEOConfig.pageSize) {
                    pagingEO(response.total, function () {
                        loadDocEO();
                    });
                }
            }
        },
        async: false
    });
}

function loadDocEE(classId, type) {
    $('#ulExerciseExtension').empty();

    var classId = [classId];
    var data = {
        ClassId: classId,
        Type: type,
    };

    $.ajax({
        url: '/Class/SearchExerciseBySelectedLsit',
        type: 'Post',
        dataType: 'Json',
        data: { model: JSON.stringify(data), pageNumber: pageEEConfig.pageIndex, pageSize: pageEEConfig.pageSize },
        success: function (response) {
            if (response.status) {
                $('#scriptExerciseExtension').tmpl(response.listClass).appendTo('#ulExerciseExtension');
                if (response.total > pageEEConfig.pageSize) {
                    pagingEE(response.total, function () {
                        loadDocEE();
                    });
                }
            }
        },
        async: false
    });
}


//End

//#region -- Helper --

///
///Pagination for SearchBySelected and SearchByTyping
///
var pageConfig = {
    pageSize: 4, // Lines to show in a page
    pageIndex: 1, // The position that you choose
}

function paging(totalRow, callBack) {
    var totalPage = Math.ceil(totalRow / pageConfig.pageSize);
    $('#paginationLP').twbsPagination({
        totalPages: totalPage,
        first: '<span aria-hidden="true">&laquo;</span>',
        next: '<span aria-hidden="true" style="font-size: 12px;">&gt;</span>',
        last: '<span aria-hidden="true">&raquo;</span>',
        prev: '<span aria-hidden="true" style="font-size: 12px;">&lt;</span>',
        visiblePages: 5,// numbers of pagination
        onPageClick: function (event, page) {
            pageConfig.pageIndex = page;
            setTimeout(callBack, 200);
        }
    });
}

///
///Pagination for SearchBySelected and SearchByTyping
///
var pageLRConfig = {
    pageSize: 4, // Lines to show in a page
    pageIndex: 1, // The position that you choose
}

function pagingLR(totalRow, callBack) {
    var totalPage = Math.ceil(totalRow / pageLRConfig.pageSize);
    $('#paginationLR').twbsPagination({
        totalPages: totalPage,
        first: '<span aria-hidden="true">&laquo;</span>',
        next: '<span aria-hidden="true" style="font-size: 12px;">&gt;</span>',
        last: '<span aria-hidden="true">&raquo;</span>',
        prev: '<span aria-hidden="true" style="font-size: 12px;">&lt;</span>',
        visiblePages: 5,// numbers of pagination
        onPageClick: function (event, page) {
            pageLRConfig.pageIndex = page;
            setTimeout(callBack, 200);
        }
    });
}

var pageLEConfig = {
    pageSize: 4, // Lines to show in a page
    pageIndex: 1, // The position that you choose
}

function pagingLE(totalRow, callBack) {
    var totalPage = Math.ceil(totalRow / pageLEConfig.pageSize);
    $('#paginationLR').twbsPagination({
        totalPages: totalPage,
        first: '<span aria-hidden="true">&laquo;</span>',
        next: '<span aria-hidden="true" style="font-size: 12px;">&gt;</span>',
        last: '<span aria-hidden="true">&raquo;</span>',
        prev: '<span aria-hidden="true" style="font-size: 12px;">&lt;</span>',
        visiblePages: 5,// numbers of pagination
        onPageClick: function (event, page) {
            pageLEConfig.pageIndex = page;
            setTimeout(callBack, 200);
        }
    });
}


var pageCPConfig = {
    pageSize: 4, // Lines to show in a page
    pageIndex: 1, // The position that you choose
}

function pagingCP(totalRow, callBack) {
    var totalPage = Math.ceil(totalRow / pageCPConfig.pageSize);
    $('#paginationCP').twbsPagination({
        totalPages: totalPage,
        first: '<span aria-hidden="true">&laquo;</span>',
        next: '<span aria-hidden="true" style="font-size: 12px;">&gt;</span>',
        last: '<span aria-hidden="true">&raquo;</span>',
        prev: '<span aria-hidden="true" style="font-size: 12px;">&lt;</span>',
        visiblePages: 5,// numbers of pagination
        onPageClick: function (event, page) {
            pageCPConfig.pageIndex = page;
            setTimeout(callBack, 200);
        }
    });
}

var pageCRConfig = {
    pageSize: 4, // Lines to show in a page
    pageIndex: 1, // The position that you choose
}

function pagingCR(totalRow, callBack) {
    var totalPage = Math.ceil(totalRow / pageCRConfig.pageSize);
    $('#paginationCP').twbsPagination({
        totalPages: totalPage,
        first: '<span aria-hidden="true">&laquo;</span>',
        next: '<span aria-hidden="true" style="font-size: 12px;">&gt;</span>',
        last: '<span aria-hidden="true">&raquo;</span>',
        prev: '<span aria-hidden="true" style="font-size: 12px;">&lt;</span>',
        visiblePages: 5,// numbers of pagination
        onPageClick: function (event, page) {
            pageCRConfig.pageIndex = page;
            setTimeout(callBack, 200);
        }
    });
}

var pageEOConfig = {
    pageSize: 4, // Lines to show in a page
    pageIndex: 1, // The position that you choose
}

function pagingEO(totalRow, callBack) {
    var totalPage = Math.ceil(totalRow / pageEOConfig.pageSize);
    $('#paginationCP').twbsPagination({
        totalPages: totalPage,
        first: '<span aria-hidden="true">&laquo;</span>',
        next: '<span aria-hidden="true" style="font-size: 12px;">&gt;</span>',
        last: '<span aria-hidden="true">&raquo;</span>',
        prev: '<span aria-hidden="true" style="font-size: 12px;">&lt;</span>',
        visiblePages: 5,// numbers of pagination
        onPageClick: function (event, page) {
            pageEOConfig.pageIndex = page;
            setTimeout(callBack, 200);
        }
    });
}

var pageEEConfig = {
    pageSize: 4, // Lines to show in a page
    pageIndex: 1, // The position that you choose
}

function pagingEE(totalRow, callBack) {
    var totalPage = Math.ceil(totalRow / pageEEConfig.pageSize);
    $('#paginationCP').twbsPagination({
        totalPages: totalPage,
        first: '<span aria-hidden="true">&laquo;</span>',
        next: '<span aria-hidden="true" style="font-size: 12px;">&gt;</span>',
        last: '<span aria-hidden="true">&raquo;</span>',
        prev: '<span aria-hidden="true" style="font-size: 12px;">&lt;</span>',
        visiblePages: 5,// numbers of pagination
        onPageClick: function (event, page) {
            pageEEConfig.pageIndex = page;
            setTimeout(callBack, 200);
        }
    });
}

//#endregion