function validate()
{

    var username = document.getElementById("txtusername").value;
    var pass = document.getElementById("txtpassword").value;
    if (username.length == 0 || pass.length == 0)
    {
        alert("enter username/password");
        return false;

    }
    else
    {
        return true;
    }


}