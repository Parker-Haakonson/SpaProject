namespace SpaProject
{
    static class LogedIn
    {
        static bool IsLogedIn = false;
        static int id;
        static string email;
        static string password;
        static bool isAdmin = false;
        static public bool GetLogedIn()
        {
            return IsLogedIn;
        }
        static public void SetLogedIn(bool logedIn)
        {
            IsLogedIn = true;
        }
        static public string GetEmail()
        {
            return email;
        }
        static public void SetEmail(string Email)
        {
            email = Email;
        }
        static public string GetPassword()
        {
            return password;
        }
        static public void SetPassword(string Password)
        {
            password = Password;
        }
        static public bool GetIsAdmin()
        {
            return isAdmin;
        }
        static public void SetIsAdmin(bool IsAdmin)
        {
            isAdmin = IsAdmin;
        }
        static public int GetId()
        {
            return id;
        }
        static public void SetId(int Id)
        {
            id = Id;
        }
    }
}
