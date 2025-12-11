namespace SpaProject
{
    static class LogedIn
    {
        static bool IsLogedIn = false;

        static public bool GetLogedIn()
        {
            return IsLogedIn;
        }
        static public void SetLogedIn(bool logedIn)
        {
            IsLogedIn = true;
        }
    }
}
