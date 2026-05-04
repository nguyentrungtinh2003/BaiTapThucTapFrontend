namespace BaiTapThucTapFrontend.Models
{
    public class PermissionDto
    {
        public string Ma_Dang_Nhap { get; set; } = "";
        public int Kho_ID { get; set; }

        public bool isAdmin { get; set; } = false;

        //public bool IsLoggedIn => !string.IsNullOrEmpty(Ma_Dang_Nhap) && Kho_ID != null;
    }
}
