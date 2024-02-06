function namefunc(){
    document.getElementById('NameErr').innerHTML=" ";
}

function dobfunc(){
    document.getElementById('DateErr').innerHTML=" ";
}

function addfunc(){
    document.getElementById('AddressErr').innerHTML=" ";
}


function mobfunc(){
    document.getElementById('MobileErr').innerHTML=" ";
}

function desigfunc(){
    document.getElementById('DesignationErr').innerHTML=" ";
}

function compfunc(){
    document.getElementById('CompanyErr').innerHTML=" ";
}

function depenfunc(){
    document.getElementById('NumberOfDependentsTxt').innerHTML=" ";
}

function accnofunc(){
    document.getElementById('AccountNumberErr').innerHTML=" ";
}
function balfunc(){
    document.getElementById('CurrentBalanceErr').innerHTML=" ";
}

function indexvalid() {
var nameip=document.getElementById('NameTxt').value;
var dobip=document.getElementById('DobTxt').value;
var addip=document.getElementById('AddressTxt').value;
var mobip=document.getElementById('MobileTxt').value;
var designationip=document.getElementById('DesignationTxt').value;
var compip=document.getElementById('CompanyTxt').value;
var dependentsip=document.getElementById('NumberOfDependentsTxt').value;
var accip=document.getElementById('AccountNumberTxt').value;
var balip=document.getElementById('CurrentBalanceTxt').value;

document.getElementById('NameTxt').addEventListener('input',namefunc);
document.getElementById('DobTxt').addEventListener('input',dobfunc);
document.getElementById('AddressTxt').addEventListener('input',addfunc);
document.getElementById('MobileTxt').addEventListener('input',mobfunc);
document.getElementById('DesignationTxt').addEventListener('input',desigfunc);
document.getElementById('CompanyTxt').addEventListener('input',compfunc);
document.getElementById('NumberOfDependentsTxt').addEventListener('input',depenfunc);
document.getElementById('AccountNumberTxt').addEventListener('input',accnofunc);
document.getElementById('CurrentBalanceTxt').addEventListener('input',balfunc);


if(nameip==''){

    document.getElementById('NameErr').style.color="red";
    document.getElementById('NameErr').innerHTML="name is empty";
    return false;
}
if(dobip==''){
    document.getElementById('DateErr').style.color="red";
    document.getElementById('DateErr').innerHTML="dob is empty";
    return false;
}

if(addip==''){
    document.getElementById('AddressErr').style.color="red";
    document.getElementById('AddressErr').innerHTML="address is empty";
    return false;
}

if(mobip.length !=10){
    document.getElementById('MobileErr').style.color="red";
    document.getElementById('MobileErr').innerHTML="mobile is invalid";
    return false;
}
if(designationip==''){
    document.getElementById('DesignationErr').style.color="red";
    document.getElementById('DesignationErr').innerHTML="designation is empty";
    return false;
}

if(compip==''){
    document.getElementById('CompanyErr').style.color="red";
    document.getElementById('CompanyErr').innerHTML="company is empty";
    return false;
}

if(dependentsip==''){
    document.getElementById('NumberOfDependentsTxt').style.color="red";
    document.getElementById('NumberOfDependentsTxt').innerHTML="dependents is empty";
    return false;
}

if(accip==''){
    document.getElementById('AccountNumberErr').style.color="red";
    document.getElementById('AccountNumberErr').innerHTML="number is empty";
    return false;
}

if(balip==''){
    document.getElementById('CurrentBalanceErr').style.color="red";
    document.getElementById('CurrentBalanceErr').innerHTML="balance is empty";
    return false;
}






    return true;
}