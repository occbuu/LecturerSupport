namespace LS.Utility
{
    public class SendCodeDto
    {
        public string SelectedProvider { get; set; }

        public string ReturnUrl { get; set; }

        public bool RememberMe { get; set; }
    }
}