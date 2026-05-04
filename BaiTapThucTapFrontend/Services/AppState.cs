namespace BaiTapThucTapFrontend.Services
{
    public class AppState
    {
        public string Ma_Dang_Nhap { get; set; } = "";
        public int Kho_ID { get; set; }
        public bool isAdmin { get; set; } = false;

        public event Action OnChange;

        public void Notify()
        {
            OnChange?.Invoke();
        }
    }
}
