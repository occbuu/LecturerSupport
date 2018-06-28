using System;
using System.ComponentModel;
using System.Linq;

namespace LS.Utility
{
    /// <summary>
    /// Category type
    /// </summary>
    public enum CategoryType
    {
        Mall,
        Type
    }

    /// <summary>
    /// Article status
    /// </summary>
    public enum ArticleStatus
    {
        /// <summary>
        /// Await Approval
        /// </summary>
        Await = 1,
        Deleted,
        Draft,
        Published,
        Rejected
    }

    /// <summary>
    /// Article like
    /// </summary>
    public enum ArticleLike
    {
        Dislike,
        Like
    }

    /// <summary>
    /// Content type
    /// </summary>
    public enum KBContentType
    {
        Article = 1,

        /// <summary>
        /// Q & A
        /// </summary>
        QnA,

        /// <summary>
        /// File Library
        /// </summary>
        FileLib,

        /// <summary>
        /// Rich Media Library
        /// </summary>
        RichMedia
    }

    /// <summary>
    /// Content review
    /// </summary>
    public enum ContentReview
    {
        ThreeMonths = 1,
        SixMonths,
        OneYear,
        TwoYears
    }

    /// <summary>
    /// Permission scope
    /// </summary>
    public enum PermissionScope
    {
        Mall = 1,
        Regional,
    }

    /// <summary>
    /// User group
    /// </summary>
    public enum UserGroup
    {
        None = 0,
        MAFUser = 1 << 0,
        TenantUser = 1 << 1,
        Both = MAFUser | TenantUser
    }

    /// <summary>
    /// All code type of Code table
    /// </summary>
    public enum CodeType
    {
        AMENDMENTSTYPE,
        APPOINTMENTCODE,
        BRAND,
        BRANDCATEGORY,
        BRANDOPTYPE,
        CAMPAIGNRESPONSE,
        CATEGORY,
        COMMTYPE,
        COMPANYTYPE,
        CONTACTTYPE,
        CONTRACTORTYPE,
        EVENTTYPE,
        FLOORLEVEL,
        GEOTRADEPROFILE,
        LANGUAGE,
        LANGUAGECODE,
        LEASECONTACTTYPE,
        LEASESTATUS,
        LEASETYPE,
        LICENSETYPE,
        MR_SUBCAT_SOC,
        MR_SUBCAT_WEB,
        NATIONALITY,
        PRLYPSUBCATEGORY,
        PRMWPSUBCATEGORY,
        RELATIONSHIPTYPE,
        REQUESTSTATUS,
        SERVICEACTION,
        SERVICEREQUEST,
        SERVICEREQUEST_LAY,
        SHOPTYPE,
        SYSTEMCODE,
        TARGETMARKET,
        TARGETPROFILE,
        TIMEOFWORKS,
        TJPMODULE,
        TYPEOFSHOOT,
        WORKFLOWSTATUS,
        PHOACTIVITYTYPE,
        MODULENAME,
        PropertyContactType,
        ITEMTYPE,
        SALUTATION
    }

    public enum PermitRequestType
    {
        LayoutChange,
        Merchandise,
        MaintenanceWorks,
    }

    public enum LayoutChangeDetail
    {
        WindowDisplay,
        BannerOtherDisplay,
        WindowFitting,
        WindowMannequin,
        InStoreLayout,
        InStorePodiumCounter
    }

    public enum MaintenanceWorksDetail
    {
        LightingFixturesSignsBulbs,
        ACSystemHVAC,
        PowerElectricalInstallations,
        PlumbingIssues,
        MechanicalShutterDoors,
        EquipmentMachinesComputersPosCashiersPhones,
        WifiInternetPhoneLinesCamerasSecurityAntennas,
        ShelvesCountersFurnitureMaintenanceWorks,
        FloorWallCeilingMaintenance,
        CarpentryPaintingWorks,
        DecorationWorks,
        Other,
    }

    public enum StoredProcedures
    {
        GetAnnouncementData,
        GetMemoData
    }

    public enum ExtraPlaceHolder
    {
        ApproverAccountName,
        TenantAccountName
    }

    /// <summary>
    /// Module code
    /// </summary>
    public enum ModuleCode
    {
        anno,
        memo,

        /// <summary>
        /// Permit Request
        /// </summary>
        pr,

        /// <summary>
        /// Marketing Campaign
        /// </summary>
        mc,

        /// <summary>
        /// Marketing Request
        /// </summary>
        mr
    }

    public enum PropertyCode
    {
        ABCC,
        ACC,
        ALEX,
        ALMAZA,
        AZCC,
        BCC,
        BECC,

        [Description("City Centre Deira")]
        DCC,

        FCC,
        MAADI,
        MAJ,
        MAK,
        MAM,
        MAQ,
        MAU,
        MAZ,
        MCC,
        MECC,
        MICC,

        [Description("Mall Of The Emirates")]
        MOE,

        MOEG,
        NCC,
        QCC,
        SCC,
        SHCC,
        SUR
    }

    #region -- For Announcement modules --

    public enum WorkFlowRequestActionType
    {
        [Description("Submitted")]
        Submit,

        [Description("Approved")]
        Approve,

        [Description("Withdrawn")]
        Withdraw,

        [Description("Redirected")]
        Redirect,

        [Description("Rejected")]
        Reject,

        [Description("Deleted")]
        Delete,

        [Description("Completed")]
        Acknowledge,

        [Description("Completed")]
        Complete,

        [Description("Replied Info")]
        ReplyInfo,

        [Description("Closed With Issue")]
        CompleteIssue,

        [Description("Collected")]
        Collect,

        [Description("Closed")]
        Close,

        [Description("Saved As Draft")]
        Draft,

        [Description("Returned for Info")]
        AskInfo,

        [Description("Escalated")]
        Escalate,

        [Description("Closed With Issue")]
        CloseIssue,

        [Description("Closed Without Issue")]
        CloseWithoutIssue,

        [Description("Checked")]
        Checked,

        [Description("Inspection Done")]
        InspectionDone
    }

    public enum WorkFlowRequestActionRole
    {
        [Description("Requester")]
        Submit,

        [Description("Approver")]
        Approve,

        [Description("Requester")]
        Withdraw,

        [Description("Approver")]
        Redirect,

        [Description("Approver")]
        Reject,

        [Description("Requester")]
        Delete,

        [Description("Tenant")]
        Acknowledge,

        [Description("Duty Manager")] //TODO differentiate complete action for diff levels by status code
        Complete,

        [Description("Requester")]
        ReplyInfo,

        [Description("Duty Manager")]
        CompleteIssue,

        [Description("Duty Manager")]
        Collect,

        [Description("Duty Manager")]
        Close,

        [Description("Requester")]
        Draft,

        [Description("Reviewer")]
        AskInfo,

        [Description("Approver")]
        Escalate
    }

    public enum WorkFlowRequestNextStatus
    {
        [Description("PENA")]
        Submit,

        [Description("APPR")]
        Approve,

        [Description("WITH")]
        Withdraw,

        [Description("RJCT")]
        Reject,

        [Description("DELT")]
        Delete,

        [Description("COMP")]
        Acknowledge,

        [Description("COMP")] //TODO differentiate complete action for diff levels by status code
        Complete,

        [Description("DRFT")] //TODO differentiate complete action for diff levels by status code
        Draft
    }

    public static class EnumHelper<T>
    {
        public static string GetEnumDescription(string value)
        {
            Type type = typeof(T);
            var name = Enum.GetNames(type)
                .Where(f => f.Equals(value, StringComparison.CurrentCultureIgnoreCase))
                .Select(d => d).FirstOrDefault();

            if (name == null)
            {
                return value;
            }
            var field = type.GetField(name);
            var customAttribute = field.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return customAttribute.Length > 0 ? ((DescriptionAttribute)customAttribute[0]).Description : name;
        }
    }

    #endregion

    /// <summary>
    /// Possible upload type
    /// </summary>
    public enum UploadType
    {
        #region -- Permit request --

        /// <summary>
        /// General attacchment
        /// </summary>
        PGE,

        #region -- Layout --
        /// <summary>
        /// Windows display
        /// </summary>
        LWD,

        /// <summary>
        /// Banner poster
        /// </summary>
        LBP,

        /// <summary>
        /// Mannequins fitting
        /// </summary>
        LMF,

        /// <summary>
        /// In store display
        /// </summary>
        LSD,

        /// <summary>
        /// In store banner
        /// </summary>
        LSB,

        /// <summary>
        /// Others
        /// </summary>
        LOT,
        #endregion

        #region -- Merchandise --
        /// <summary>
        /// General attacchment
        /// </summary>
        MGE,

        /// <summary>
        /// Stock counting audit
        /// </summary>
        MSC,

        /// <summary>
        /// Stock taking
        /// </summary>
        MST,

        /// <summary>
        /// Remerchandising
        /// </summary>
        MRC,
        #endregion

        #region -- Maintainance --
        /// <summary>
        /// Lighting fixtures
        /// </summary>
        WLF,

        /// <summary>
        /// AC system
        /// </summary>
        WAC,

        /// <summary>
        /// Power electrical
        /// </summary>
        WPE,

        /// <summary>
        /// Plumbing
        /// </summary>
        WPL,

        /// <summary>
        /// Mechanical shutter door
        /// </summary>
        WMS,

        /// <summary>
        /// Equip com POS phone
        /// </summary>
        WEC,

        /// <summary>
        /// Wifi internet PhLine
        /// </summary>
        WWP,

        /// <summary>
        /// Furniture
        /// </summary>
        WFU,

        /// <summary>
        /// Floor wall ceiling
        /// </summary>
        WFW,

        /// <summary>
        /// Carpentry painting
        /// </summary>
        WCP,

        /// <summary>
        /// Decoration
        /// </summary>
        WDE,

        /// <summary>
        /// Others
        /// </summary>
        WOT,
        #endregion

        #region -- NOC --
        /// <summary>
        /// Contractor trade license
        /// </summary>
        NCT,

        /// <summary>
        /// Tenant trade license
        /// </summary>
        NTT,

        /// <summary>
        /// Labor card
        /// </summary>
        NLC,
        #endregion

        #region -- Photography --
        /// <summary>
        /// General attachment
        /// </summary>
        PHO,

        /// <summary>
        /// Insurance attachment
        /// </summary>
        INS,

        /// <summary>
        /// NOC attachment
        /// </summary>
        NOC,
        #endregion

        #region -- EVT --

        /// <summary>
        /// General attachment
        /// </summary>
        EVT,

        #endregion

        #endregion

        #region -- Marketing request --

        /// <summary>
        /// Free attachments
        /// </summary>
        GEN,

        /// <summary>
        /// Pdf file
        /// </summary>
        COL,

        /// <summary>
        /// Thumbnail
        /// </summary>
        THU,

        /// <summary>
        /// Zip file
        /// </summary>
        PRD,

        /// <summary>
        /// Xls file
        /// </summary>
        XLS,

        /// <summary>
        /// Social image
        /// </summary>
        SIM,

        /// <summary>
        /// Images
        /// </summary>
        GAL,

        /// <summary>
        /// Videos
        /// </summary>
        VID,

        #endregion

        #region -- Other --

        /// <summary>
        /// Annoucement
        /// </summary>
        ANNO,

        /// <summary>
        /// Memo
        /// </summary>
        MEMO,

        /// <summary>
        /// Lost and Found
        /// </summary>
        LF,

        /// <summary>
        /// Campaign
        /// </summary>
        MCAMP,
        RES,
        ICON,

        FBACK //20161122 Frederick - Feedback form

        #endregion
    }

    /// <summary>
    /// Text format
    /// </summary>
    public enum Format
    {
        /// <summary>
        /// Sentence case
        /// </summary>
        Sentence,

        /// <summary>
        /// lower case
        /// </summary>
        Lower,

        /// <summary>
        /// UPPER CASE
        /// </summary>
        Upper,

        /// <summary>
        /// Capitalized Case
        /// </summary>
        Capitalized,

        /// <summary>
        /// Orginal string
        /// </summary>
        Orginal
    }

    /// <summary>
    /// Language code
    /// </summary>
    public enum LangCode
    {
        /// <summary>
        /// English
        /// </summary>
        EN,

        /// <summary>
        /// Arabic
        /// </summary>
        AR
    }

    #region -- PR --

    /// <summary>
    /// Permit request code
    /// </summary>
    public enum PRCode
    {
        /// <summary>
        /// Layout
        /// </summary>
        LYP,

        /// <summary>
        /// Merchandise
        /// </summary>
        MDP,

        /// <summary>
        /// Maintenance
        /// </summary>
        MWP,

        /// <summary>
        /// NOC
        /// </summary>
        NOC,

        /// <summary>
        /// PHO
        /// </summary>
        PHO,

        /// <summary>
        /// EVT
        /// </summary>
        EVT
    }

    /// <summary>
    /// Permit request action
    /// </summary>
    public enum PRAction
    {
        /// <summary>
        /// None
        /// </summary>
        None,

        /// <summary>
        /// Repair
        /// </summary>
        Repair,

        /// <summary>
        /// Add
        /// </summary>
        Add,

        /// <summary>
        /// Change
        /// </summary>
        Change,

        /// <summary>
        /// Remove
        /// </summary>
        Remove,

        /// <summary>
        /// Yes
        /// </summary>
        Yes,

        /// <summary>
        /// No
        /// </summary>
        No
    }

    /// <summary>
    /// Permit request status
    /// </summary>
    public enum PRStatus
    {
        /// <summary>
        /// Approved
        /// </summary>
        APPR = 1,

        /// <summary>
        /// Cancelled
        /// </summary>
        CANC,

        /// <summary>
        /// Closed
        /// </summary>
        CLOS,

        /// <summary>
        /// Closed with Issue
        /// </summary>
        CLWI,

        /// <summary>
        /// Collected
        /// </summary>
        COLT,

        /// <summary>
        /// Completed
        /// </summary>
        COMP,

        /// <summary>
        /// Deleted
        /// </summary>
        DELT,

        /// <summary>
        /// Draft
        /// </summary>
        DRFT,//

        /// <summary>
        /// New
        /// </summary>
        NEW,

        /// <summary>
        /// Await Approval
        /// </summary>
        PENA,

        /// <summary>
        /// Await Collection
        /// </summary>
        PENC,

        /// <summary>
        /// Await Inspect
        /// </summary>
        PEND,

        /// <summary>
        /// Await Follow-up
        /// </summary>
        PENF,

        /// <summary>
        /// Await Response
        /// </summary>
        PENP,

        /// <summary>
        /// Await Reply
        /// </summary>
        PENR,

        /// <summary>
        /// Await NOC Preparation
        /// </summary>
        PENT,
        /// <summary>
        /// Await Review
        /// </summary>
        PENV,

        /// <summary>
        /// Processing
        /// </summary>
        PRCS,

        /// <summary>
        /// Published
        /// </summary>
        PUBL,

        /// <summary>
        /// Rejected
        /// </summary>
        RJCT,

        /// <summary>
        /// Withdrawn
        /// </summary>
        WITH,

        /// <summary>
        /// Await Action Taker 1
        /// </summary>
        PATO,

        /// <summary>
        /// Await Action Taker 2
        /// </summary>
        PATT
    }

    /// <summary>
    /// Priority
    /// </summary>
    public enum Priority
    {
        /// <summary>
        /// Normal
        /// </summary>
        NOR,

        /// <summary>
        /// Urgent
        /// </summary>
        URG
    }

    /// <summary>
    /// Type of shoot
    /// </summary>
    public enum TypeOfShoot
    {
        /// <summary>
        /// Tenant In Shop
        /// </summary>
        INSHOP,

        /// <summary>
        /// Public/Common Areas
        /// </summary>
        PUBLICCOMMON
    }

    #endregion

    #region -- MR --

    /// <summary>
    /// Marketing request code
    /// </summary>
    public enum MRCode
    {
        /// <summary>
        /// Website
        /// </summary>
        [Description("Web")]
        WEB,

        /// <summary>
        /// Social
        /// </summary>
        [Description("Social")]
        SOC,

        /// <summary>
        /// Both
        /// </summary>
        [Description("Both")]
        Both
    }

    /// <summary>
    /// Marketing request sub code
    /// </summary>
    public enum MRSubCode
    {
        /// <summary>
        /// Events
        /// </summary>
        [Description("Events")]
        EVT,

        /// <summary>
        /// Offers
        /// </summary>
        [Description("Offers")]
        OFR,

        /// <summary>
        /// Latest collections (PDF)
        /// </summary>
        [Description("Latest collections (PDF)")]
        LCO,

        /// <summary>
        /// Store description
        /// </summary>
        [Description("Store description")]
        STD,

        /// <summary>
        /// Product catalogues (PDF)
        /// </summary>
        [Description("Product catalogues (PDF)")]
        PDC,

        /// <summary>
        /// Promotional Catalogues (PDF)
        /// </summary>
        [Description("Promotional Catalogues (PDF)")]
        PMC,

        /// <summary>
        /// Featured products
        /// </summary>
        [Description("Featured products")]
        FEP,

        /// <summary>
        /// Sale products
        /// </summary>
        [Description("Sale products")]
        SLP,

        /// <summary>
        /// New products
        /// </summary>
        [Description("New products")]
        NWP,

        /// <summary>
        /// Image gallery
        /// </summary>
        [Description("Image gallery")]
        IMG,

        /// <summary>
        /// Videos (Entertainment)
        /// </summary>
        [Description("Videos (Entertainment)")]
        VID,

        /// <summary>
        /// Blog
        /// </summary>
        [Description("Blog")]
        BLG
    }

    public enum PossibleProperties
    {
        /// <summary>
        /// Youtube link
        /// </summary>
        YTL,

        /// <summary>
        /// Youtube description
        /// </summary>
        YTD,

        /// <summary>
        /// Image description
        /// </summary>
        IMD
    }

    #endregion

    #region -- LF --

    /// <summary>
    /// Item value code
    /// </summary>
    public enum ItemValue
    {
        /// <summary>
        /// IDE
        /// </summary>
        IDE,

        /// <summary>
        /// HIG
        /// </summary>
        HiG,

        /// <summary>
        /// LOW
        /// </summary>
        LOW
    }

    #endregion

    public enum TPAppSettings
    {
        /// <summary>
        /// Use forget password when send email confirm
        /// </summary>
        ExpiredTimeLife
    }

    /// <summary>
    /// PR resource name
    /// </summary>
    public enum PRResource
    {
        #region -- Title --

        TitleViewLayoutPermit,

        TitleViewMerchandisingPermit,

        TitleViewMaintenanceWorksPermit,

        TitleRequestForNOC,

        #endregion

        #region -- Label --

        RequestforLayoutPermit,

        RequestforMerchandisingPermit,

        RequestforMaintenanceWorksPermit,

        RequestforNOC,

        #endregion

        #region -- Layout --

        LblWindowDisplay,

        LblBannerPoster,

        LblMannequinsFitting,

        LblInStoreDisplay,

        LblInStoreBanner,

        LblOthers,

        LblLayoutPermitDetails,

        #endregion

        #region -- Maintenance --

        LightingFixtures,

        ACSystem,

        PowerElectrical,

        Plumbing,

        MechanicalShutterDoor,

        EquipComPOSPhone,

        WifiInternetPhLine,

        Furniture,

        FloorWallCeiling,

        Decoration,

        Carpentry,

        Other,

        LblMaintenanceWorksPermitDetails,

        #endregion

        #region -- NOC --

        LblContractorDetails,

        LblTradeLicense,

        LblLaborCard,

        LblNOCDetails,

        #endregion

        #region -- PHO --

        #endregion

        #region -- EVT --

        #endregion

        #region -- Merchandise --

        StockCountingAudit,

        StockTaking,

        Remerchandising,

        LblMerchandisingPermitDetails

        #endregion
    }

    /// <summary>
    /// LF resource name
    /// </summary>
    public enum LFResource
    {
        #region -- Item value --

        LblHigh,

        LblLow,

        LblIDE

        #endregion
    }

    /// <summary>
    /// MR resource name
    /// </summary>
    public enum MRResource
    {
        #region -- Tab label --

        TabLblSubjectEN,

        TabLblSubjectAR,

        TabLblDescriptionEN,

        TabLblDescriptionAR,

        TabLblPdfEN,

        TabLblPdfAR,

        TabLblThbEN,

        TabLblThbAR,

        TabLblSocialImageEN,

        TabLblSocialImageAR,

        TabLblPublishingDateEN,

        TabLblPublishingDateAR,

        TabLblPublishingInfoEN,

        TabLblPublishingInfoAR,

        TabLblFreeAttachmentsEN,

        TabLblFreeAttachmentsAR,

        TabLblZipEN,

        TabLblZipAR,

        TabLblXlsEN,

        TabLblXlsAR,

        TabLblImageDescriptionEN,

        TabLblImageDescriptionAR

        #endregion
    }

    /// <summary>
    /// Configuration email template
    /// </summary>
    public enum ConfigEmailTemplate
    {
        /// <summary>
        /// ReferenceNo = ResetPassword
        /// </summary>
        ResetPassword,

        /// <summary>
        /// ReferenceNo = ActivateAccount
        /// </summary>
        ActivateAccount
    }

    public enum EventCalendarResource
    {
        /// <summary>
        /// Announcement
        /// </summary>
        ColorHoliday,

        /// <summary>
        /// Memo
        /// </summary>
        ColorEvent,

        /// <summary>
        /// Permit Request
        /// </summary>
        ColorPhotography,

        /// <summary>
        /// Marketing Campaign
        /// </summary>
        ColorLayoutPermit,

        /// <summary>
        /// Marketing Request
        /// </summary>
        ColorMechandising,

        ColorMaintenance
    }

    /// <summary>
    /// Admin PR resource name
    /// </summary>
    public enum AdminResource
    {
        #region -- PRType --

        LayoutChangePermit,

        MaintenanceWorksPermit,

        MerchandisingPermit,

        EventPermit,

        PhotographyPermit

        #endregion
    }
}