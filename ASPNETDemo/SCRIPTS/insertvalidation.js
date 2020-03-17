function ivalidate() {
    var eno = document.getElementById("txtempno").value;
    var ename = document.getElementById("txtename").value;
    var job = document.getElementById("txtjob").value;
    var mgr = document.getElementById("txtmgr").value;
    var hiredate = document.getElementById("txthiredate").value;
    var sal = document.getElementById("txtsal").value;
    var comm = document.getElementById("txtcomm").value;
    var deptno = document.getElementById("txtdeptno").value;

    if (eno.length == 0 || ename.length == 0 || job.length == 0 || mgr.length == 0 || hiredate.length == 0 || sal.length == 0 || comm.length == 0 || deptno.length == 0) {
        alert("enter all details");
        return false;


    }
    else {
        return true;
    }


}

