function dvalidate()
{

    var empno = document.getElementById("txtempno").value;
    if (empno.length == 0) {
        alert("enter a empno");
        return false;

    }
    else {
        return true;
    }

}