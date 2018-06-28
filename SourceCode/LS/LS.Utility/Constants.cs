using System;

namespace LS.Utility
{
    public class Constants
    {
        public const string ActiveStatus = "1";
        public const string InactiveStatus = "0";
        public const string AllStatus = "All";
        public const string English = "en-US";
        public const string Japan = "ja-JP";
        public const string VietNam = "vi-VN";
        public class Message_Status
        {
            public const string Created = "1";
            public const string Read = "1A";
            public const string Completed = "2";
            public const string Canceled = "0";
        }

        public class Users_Status
        {
            public const string ActiveStatus = "1";
            public const string InactiveStatus = "0";
            public const string SuspendedStatus = "2";
            public const string Deleted = "-1";
        }

        public class Role_Status
        {
            public const string ActiveStatus = "1";
            public const string InactiveStatus = "0";
            public const string SuspendedStatus = "2";
            public const string Deleted = "-1";
        }

        public class QA_Status
        {
            public const string ActiveStatus = "1";
            public const string InactiveStatus = "0";
            public const string SuspendedStatus = "2";
        }

        public class SiteInfo_Status
        {
            public const string ActiveStatus = "1";
            public const string InactiveStatus = "0";
            public const string SuspendedStatus = "2";
        }

        public class Subject_Status
        {
            public const string ActiveStatus = "ACT";
            public const string InactiveStatus = "IACT";
        }

        public class Class_Status
        {
            public const string ActiveStaus = "1";
            public const string InactiveStatus = "0";
            public const string CommingStatus = "2";
            public const string DeleteStatus = "-1";
            public const string All = "10";
        }

        public class Document_Status
        {
            public const string ActiveStaus = "1";
            public const string InactiveStatus = "0";
            public const string CommingStatus = "2";
            public const string DeleteStatus = "-1";
            public const string All = "10";
        }

        public class AssignmentConfig_Status
        {
            public const string ActiveStaus = "1";
            public const string InactiveStatus = "0";
            public const string CommingStatus = "2";
            public const string DeleteStatus = "-1";
            public const string All = "10";
        }

        public class CourseScore_Status
        {
            public const string ActiveStaus = "1";
            public const string InactiveStatus = "0";
            public const string DeleteStatus = "-1";
            public const string All = "10";
        }

        public class StudentClass_Status
        {
            public const string ActiveStaus = "1";
            public const string InactiveStatus = "0";
            public const string CommingStatus = "2";
            public const string DeleteStatus = "-1";
            public const string All = "10";
        }

        public class University_Staus
        {
            public const string All = "10";
        }

        public class News_Status
        {
            public const string ActiveStatus = "1";
            public const string InactiveStatus = "0";
            public const string SuspendedStatus = "2";
        }

        public class Comment_Status
        {
            public const string ActiveStatus = "1";
            public const string InactiveStatus = "0";
            public const string SuspendedStatus = "2";
        }

        public class Schedule_Status
        {
            public const string ActiveStaus = "1";
            public const string InactiveStatus = "0";
            public const string DeleteStatus = "-1";
            public const string All = "10";
        }

        public class Libs_Status
        {
            public const string ActiveStatus = "1";
            public const string InactiveStatus = "0";
            public const string SuspendedStatus = "2";
        }

        public class FunctionCode
        {
            public const string Dashboard = "BE01";

            public const string QuanLyLopHoc = "BE02";
            public const string QuanLyLopHoc_DanhSach = "BE0201";
            public const string QuanLyLopHoc_ThemMoi = "BE0202";
        }

        public static string GetUserStatusDisplay(string status)
        {
            switch (status)
            {
                case "1": return "Đang hoạt động";
                case "2": return "Bị khóa";
                case "0": return "Ngừng hoạt động";
                case "-1": return "Xóa";
            }
            return string.Empty;
        }

        public class Document
        {
            public const string CommonTypeId = "Document";
            public const string Conspectus = "Conspectus";
            public const string LessonReferences = "LessonReferences";
            public const string Exercise = "Exercise";

            public const long All = 10;

            public const string DirSaveConspectusDoc = "~/Links/Document/Conspectus/";
            public const string DirConspectusDoc = "/Links/Document/Conspectus/";

            public const string DirSaveLessonDoc = "~/Links/Document/Lesson/";
            public const string DirLessonDoc = "/Links/Document/Lesson/";

            public const string DirSaveExercisenDoc = "~/Links/Document/Exercise/";
            public const string DirExerciseDoc = "/Links/Document/Exercise/";

            public const string DocLessonPrimary = "LessonReferences-1";
            public const string DocLessonReferences = "LessonReferences-2";
            public const string DocLessonExtention = "LessonReferences-3";

            public const string DocConspectusPrimary = "Conspectus-1";
            public const string DocConspectusReferences = "Conspectus-2";

            public const string DocExercisePrimary = "Exercise-1";
            public const string DocExerciseExtention = "Exercise-2";

        }

        public class StudentExercise
        {
            public const string DirSaveExercise = "~/Links/Document/StudentExercise/";
            public const string DirExercise = "/Links/Document/StudentExercise/";
        }

        public class InfoType
        {
            public const string Name = "Name";
            public const string Home = "Home";
            public const string Header = "Header";
            public const string Footer = "Footer";
            public const string Announcement = "Announcement";
            public const string English = "English";
            public const string LEnglish = "eng";
            public const string LJapan = "ja-JP";
            public const string LVietNam = "vi-VN";
            public const string Introduction = "Introduction";
            public const string TopBar = "TopBar";
            public const string JapaneseStudies = "JapaneseStudies";
            public const string MultiLanguage = "MultiLanguage";
            public const string GetInTouch = "GetInTouch";
            public const string SocialNetwork = "SocialNetwork";
            public const string FooterImages = "FooterImages";
            public const string FooterName = "FooterName";
            public const string FooterInfo = "FooterInfo";
            public const string CopyRight = "CopyRight";
            public const string TermAndCondition = "TermAndCondition";
            public const string PrivacyPolicy = "PrivacyPolicy";
            public const string DelegateStudents = "DelegateStudents";
            public const string DirOfImageDelegateStudents = "Content/images/students/";
            public const string SiteInfoHome = "SiteInfoHome";
            public const string Setting = "Setting";
            public const string Japanese = "Japanese";
            public const string NewsCategory = "NewsCategory";
            public const string ResearchWorks = "Research Works";

        }

        public class Home
        {
            public const string Content = "Content";
            public const string MoreAboutLecturers = "MoreAboutLecturers";
            public const string ImagesOfTeacher = "ImagesOfTeacher";
            public const string ImagesClass = "Images Class";
            public const string ViewFullPortfolio = "ViewFullPortfolio";
            public const string DashBoard = "Dashboard";
            public const string ThisisMyClasses = "ThisisMyClasses";
            public const string WeAlwaysSatisfyYou = "WeAlwaysSatisfyYou";
            public const string DelegateStudents = "Delegate Students";
            public const string Comment = "Comment";
        }

        public class AboutMe
        {
            public const string AboutMeView = "AboutMe";
            public const string WhoAmI = "WhoAmI";
            public const string ContentAndImage = "ContentAndImage";
            public const string EducationBackground = "EducationBackground";
            public const string EducationBackgroundDefault = "EducationBackgroundDefault";
            public const string CurrentJob = "CurrentJob";
            public const string Lecture = "Lecture";
            public const string DirImagesOfTeacher = "Content/images/thanhdieu/";
            public const string DirImagesOfBackground = "Content/images/about/";
            public const string EducationBackgroundChild = "EducationBackgroundChild";
            public const string ContentOfBackgroundDefault = "ContentOfBackgroundDefault";
            public const string ContentOfJobOfCurrentJoDefault = "ContentOfJobOfCurrentJoDefault";
        }

        public class Class
        {
            public const string DirOfimageClass = "/Content/images/subject/";
            public const string DirSaveImagesClass = "~/Content/images/subject/";
        }

        public class Teaching
        {
            public const string UndergraduateTeaching = "UndergraduateTeaching";
            public const string TeachingView = "Teaching";
            public const string PostgraduateTeaching = "PostgraduateTeaching";
        }

        public class Studies
        {
            public const string StudiesView = "Studies";
            public const string ResearchInterests = "ResearchInterests";
        }

        public class ResearchWork
        {
            public const string ResearchWorkView = "ResearchWork";
            public const string BookVM = "BOOKS";
            public const string JournalArticlesVM = "JOURNALARTICLES";
            public const string ResearchProjects = "ResearchProjects";
            public const string JournalArticles = "JournalArticles";
            public const string ConferenceProceedings = "ConferenceProceedings";
            public const string Books = "Books";

        }

        public class MemoryAndGallery
        {
            public const string MemoryAndGalleryVM = "MemoryAndGallery";
            public const string MyClassGallery = "MyClassGallery";
            public const string DirImagesOfMyClass = "Content/images/classes/";
        }

        public class Teacher
        {
            public const string TranThiThanhDieu = "Trần Thị Thanh Diệu";
            public const string Avartar = "Avartar";
            public const string EducationBackground = "EducationBackground";
            public const string CurrentJob = "CurrentJob";
        }

        public class UserFront
        {
            public const string DirImagesUser = "Content/images/avatar-user/";
            public const string DirSaveImagesUser = "~/Content/images/avatar-user/";
            public const string ErrorUpdateUser = "Cant not update your profile. Please check again!";
        }

    }

    /// <summary>
    /// DateTime format string
    /// </summary>
    public class DateTimeFormat
    {
        /// <summary>
        /// dd-MMM-yyyy
        /// </summary>
        public const string Date = "dd-MMM-yyyy";

        /// <summary>
        /// hh:mm tt
        /// </summary>
        public const string TimeNoSec = "hh:mm tt";

        /// <summary>
        /// HH:mm:ss
        /// </summary>
        public const string Time = "HH:mm:ss";

        /// <summary>
        /// dd-MMM-yyyy hh:mm tt
        /// </summary>
        public const string DateTimeNoSec = Date + " " + TimeNoSec;

        /// <summary>
        /// dd-MMM-yyyy h:mm:ss tt
        /// </summary>
        public const string DateTime = "dd-MMM-yyyy hh:mm:ss tt";

        /// <summary>
        /// yyyy-MM-dd HH:mm:ss
        /// </summary>
        public const string SqlDateTime = "yyyy-MM-dd " + Time;

        /// <summary>
        /// MM/dd/yyyy HH:mm:ss
        /// </summary>
        public const string IsoDateTime = "yyyy/MM/dd " + Time;

        /// <summary>
        /// {0:dd-MMM-yyyy h:mm:ss tt}
        /// </summary>
        public const string GridDateTime = "{0:" + DateTime + "}";

        /// <summary>
        /// {0:dd-MMM-yyyy}
        /// </summary>
        public const string GridDate = "{0:" + Date + "}";

        /// <summary>
        /// {0:hh:mm tt}
        /// </summary>
        public const string GridTime = "{0:" + TimeNoSec + "}";
    }

    /// <summary>
    /// Special string
    /// </summary>
    public class SpecialString
    {
        public const string Slash = "/";

        public const string BackSlash = @"\";

        public const string Space = " ";

        public const string Semicolon = ";";

        public const string Comma = ",";

        public const string Question = "?";

        public const string Asterisk = "*";

        public const string Caret = "^";

        public const string Plus = "+";

        public const string Blank = "";

        public const string Hyphen = "-";

        public const string Dot = ".";

        public const string Quotation = "\"";

        public const string LeftSquare = "[";

        public const string RightSquare = "]";

        public const string Underscore = "_";

        public const string VBar = "|";

        public const string Ampersand = "&";

        public const string Percent = "%";

        /// <summary>
        /// ", "
        /// </summary>
        public const string CommaSpace = Comma + Space;

        /// <summary>
        /// //
        /// </summary>
        public const string DouleSlash = Slash + Slash;

        public const string CarriageReturn = "\r\n";

        public const string BrTag = "<br/>";

        /// <summary>
        /// Vietnamese dong
        /// </summary>
        public const string VND = "₫";

        /// <summary>
        /// United States dollar 
        /// </summary>
        public const string USD = "$";
    }

    /// <summary>
    /// Special char
    /// </summary>
    public class SpecialChar
    {
        public const char Slash = '/';

        public const char BackSlash = '\\';

        public const char Space = ' ';

        public const char Semicolon = ';';

        public const char Comma = ',';

        public const char Question = '?';

        public const char Asterisk = '*';

        public const char Caret = '^';

        public const char Plus = '+';

        public const char Hyphen = '-';

        public const char Dot = '.';

        public const char Quotation = '"';

        public const char LeftSquare = '[';

        public const char RightSquare = ']';

        public const char Underscore = '_';

        public const char VBar = '|';

        public const char Ampersand = '&';

        public const char Percent = '%';
    }

    /// <summary>
    /// String format
    /// </summary>
    public class StringFormat
    {
        /// <summary>
        /// {0}://{1}
        /// </summary>
        public const string Host = "{0}://{1}";
    }

    /// <summary>
    /// Default value
    /// </summary>
    public class DefaultValue
    {
        #region -- DateTime --

        /// <summary>
        /// Min date
        /// </summary>
        public static DateTime MinDate = new DateTime(1900, 1, 1);

        /// <summary>
        /// Max date
        /// </summary>
        public static DateTime MaxDate = new DateTime(2099, 12, 31);

        #endregion

        #region -- String --

        /// <summary>
        /// Home controller
        /// </summary>
        public const string Home = "Home";

        /// <summary>
        /// True
        /// </summary>
        public const string True = "True";

        #endregion

        #region -- Int --

        /// <summary>
        /// Max items per row
        /// </summary>
        public const int MaxItems = 4;

        #endregion
    }

    public class UrlImages
    {
        public const string ImagesPost = "/Links/News/Post/";
        public static string ImagesEnglish { get; set; }
        public const string ImageAvatar = "/Content/images/avatar-user/";
    }

    public class UrlFiles
    {
        public const string Library = "/Links/Library/";
    }
}