﻿//Common Data Load function
// Do not modify any function.
//If needs any create new
//Author :  Shaon
//setControlId = html input control id, bindId and bindName is attribute from database

function _getZone_Active(setControlId, bindId, bindName) {
    $.ajax({
        url: '/CommonDataLoad/GetZone_Active',
        dataType: 'json',
        type: "Get",
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select Zone ---</option>").val(0));
            for (var i = 0; i < result.length; i++) {
                setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

            }
        },
        complete: function () {
            setControlId.select2();
        }
    });

}

function _getUserList_Active(setControlId, bindId, bindName) {

    $.ajax({
        url: '/CommonDataLoad/GetUserList_Active',
        dataType: 'json',
        type: "Get",
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select User ---</option>").val(""));
            for (var i = 0; i < result.length; i++) {
                setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

            }
        },
        complete: function () {

            setControlId.select2();
            //    setControlId.select2();
        }
    });

}

function _getEmployeeList_Active_Disable(setControlId, bindId, bindName, SetId) {
    var IsDisable = 'IsDisable';
    $.ajax({
        url: '/CommonDataLoad/GetEmployeeList_Active',
        dataType: 'json',
        type: "Get",
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select Employee ---</option>").val("0"));
            for (var i = 0; i < result.length; i++) {
                debugger;
                if (result[i][IsDisable] == 1) {
                    
                    setControlId.append($("<option disabled='disabled'></option>").val(result[i][bindId]).html(result[i][bindName]));
                } else {
                  
                    setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));
                }

       

            }
        },
        complete: function () {
            setControlId.val(SetId);
            setControlId.select2();
            //    setControlId.select2();
        }
    });

}

function _getEmployeeList_Active(setControlId, bindId, bindName, SetId) {
 
    $.ajax({
        url: '/CommonDataLoad/GetEmployeeList_Active',
        dataType: 'json',
        type: "Get",
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>Select From List</option>").val("0"));
            for (var i = 0; i < result.length; i++) {
                
                setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));
                
            }

            setControlId.select2();
        },
        complete: function () {

            setControlId.val(SetId);
        }
    });

}



function _getDepartment_Active(setControlId, bindId, bindName, SetId) {

    $.ajax({
        url: '/CommonDataLoad/GetDepartment_Active',
        dataType: 'json',
        type: "Get",
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select Department ---</option>").val("0"));
            for (var i = 0; i < result.length; i++) {
                setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

            }
        },
        complete: function () {
            setControlId.val(SetId);
            setControlId.select2();
            //    setControlId.select2();
        }
    });

}


function _getDesignation_Active_Emp(setControlId, bindId, bindName, SetId) {

    $.ajax({
        url: '/CommonDataLoad/GetDesignation_Active_Emp',
        dataType: 'json',
        type: "Get",
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select Designation ---</option>").val("0"));
            for (var i = 0; i < result.length; i++) {
                setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

            }
        },
        complete: function () {
            setControlId.val(SetId);
            setControlId.select2();
            //    setControlId.select2();
        }
    });

}


function _getShift_Active(setControlId, bindId, bindName, SetId) {

    $.ajax({
        url: '/CommonDataLoad/GetShift_Active',
        dataType: 'json',
        type: "Get",
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select Shift ---</option>").val("0"));
            for (var i = 0; i < result.length; i++) {
                setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

            }
        },
        complete: function () {
            setControlId.val(SetId);
            setControlId.select2();
            //    setControlId.select2();
        }
    });

}


function _getCompanyList_Active(setControlId, bindId, bindName, SetId) {
     
    $.ajax({
        url: '/CommonDataLoad/GetEmployeeList_Active',
        dataType: 'json',
        type: "Get",
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select Employee ---</option>").val("0"));
            for (var i = 0; i < result.length; i++) {
                setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

            }
        },
        complete: function () {
            setControlId.val(SetId);
          setControlId.select2();
        //    setControlId.select2();
        }
    });

}

function _getTourTypeList_Active(setControlId, bindId, bindName, SetId) {

    $.ajax({
        url: '/CommonDataLoad/GetTourTypeList_Active',
        dataType: 'json',
        type: "Get",
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select Tour Type ---</option>").val("0"));
            for (var i = 0; i < result.length; i++) {
                setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

            }
        },
        complete: function () {
            setControlId.val(SetId);
            setControlId.select2();
            //    setControlId.select2();
        }
    });

}


function _getTransportList_Active(setControlId, bindId, bindName, SetId) {

    $.ajax({
        url: '/CommonDataLoad/GetTransportList_Active',
        dataType: 'json',
        type: "Get",
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select Transport ---</option>").val("0"));
            for (var i = 0; i < result.length; i++) {
                setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

            }
        },
        complete: function () {
            setControlId.val(SetId);
            setControlId.select2();
            //    setControlId.select2();
        }
    });

}


function _GetFiscalYearInfo_Active(setControlId, bindId, bindName, setId) {
    $.ajax({
        url: '/CommonDataLoad/GetFiscalYearInfo_Active',
        dataType: 'json',
        type: "Get",
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select Fiscal Year ---</option>").val(0));
            for (var i = 0; i < result.length; i++) {
                setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

            }
        },
        complete: function () {

            setControlId.val(setId);
            setControlId.select2();
        }
    });

}
function _GetGroupInfo_Active(setControlId, bindId, bindName, setId) {
    $.ajax({
        url: '/CommonDataLoad/GetGroupInfo_Active',
        dataType: 'json',
        type: "Get",
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select Group ---</option>").val(0));
            for (var i = 0; i < result.length; i++) {
                setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

            }
        },
        complete: function () {

            setControlId.val(setId);
            setControlId.select2();
        }
    });

}

function _GetGroupInfo_All(setControlId, bindId, bindName, setId) {
    $.ajax({
        url: '/CommonDataLoad/GetGroupInfo_All',
        dataType: 'json',
        type: "Get",
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select Group ---</option>").val(0));
            for (var i = 0; i < result.length; i++) {
                var data = result[i][bindName];
                var arr = data.split('(');


                if (arr[1] == 'Inactive)') {
                    setControlId.append($("<option disabled></option>").val(result[i][bindId]).html(result[i][bindName]));

                }
                else {
                    setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

                }
            }
        },
        complete: function () {

            setControlId.val(setId);
            setControlId.select2();
        }
    });

}
function _getZone_Active_SetValue(setControlId, bindId, bindName,setId) {
    $.ajax({
        url: '/CommonDataLoad/GetZone_Active',
        dataType: 'json',
        type: "Get",
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select Zone ---</option>").val(""));
            for (var i = 0; i < result.length; i++) {
                setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

            }
        },
        complete: function () {
        
            setControlId.val(setId);
            setControlId.select2();
        }
    });

}


function _Zone_Active(setControlId, bindId, bindName, id) {
    debugger;
    $.ajax({
        url: '/CommonDataLoad/GetZone_ActiveById',
        dataType: 'json',
        type: "Get",
        data: { id: id },
        async: true,
        success: function (data) {
            debugger;
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select Zone ---</option>").val(""));
            for (var i = 0; i < result.length; i++) {
                setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

            }
        },
        complete: function () {
            setControlId.select2();
        }
    });

}

function _Zone_ActiveAll(setControlId, bindId, bindName,  setId, id) {
    debugger;
    $.ajax({
        url: '/CommonDataLoad/GetZone_ActiveById',
        dataType: 'json',
        type: "Get",
        data: { id: id },
        async: true,
        success: function (data) {
            debugger;
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select Zone ---</option>").val(""));
            for (var i = 0; i < result.length; i++) {
                setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

            }
        },
        complete: function () {
            setControlId.val(setId);
            setControlId.select2();
        }
    });

}



function _getZone_ByGroupId_Active(setControlId, bindId, bindName, id) {

    $.ajax({

        url: '/CommonDataLoad/GetZone_byGroupId_Active',
        dataType: 'json',
        type: "Get",
        data: { id: id },
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select Zone ---</option>").val(0));
            for (var i = 0; i < result.length; i++) {
                setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

            }
        },
        complete: function () {
            setControlId.select2();
        }
    });

}

function _getZone_ByGroupId_Active_SetValue(setControlId, bindId, bindName, id, setId) {
    $.ajax({
        url: '/CommonDataLoad/GetZone_byGroupId_Active',
        dataType: 'json',
        type: "Get",
        data: { id: id },
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select  ---</option>").val(0));
            for (var i = 0; i < result.length; i++) {
                setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

            }
        },
        complete: function () {
            setControlId.val(setId);
            setControlId.select2();

        }
    });

}


function _getZone_ByGroupId_All_SetValue(setControlId, bindId, bindName, id, setId) {
    $.ajax({
        url: '/CommonDataLoad/GetZone_byGroupId_All',
        dataType: 'json',
        type: "Get",
        data: { id: id },
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select  ---</option>").val(0));
            for (var i = 0; i < result.length; i++) {
                var data = result[i][bindName];
                var arr = data.split('(');

              
                if (arr[1] == 'Inactive)') {
                    setControlId.append($("<option disabled></option>").val(result[i][bindId]).html(result[i][bindName]));
                    
                }
                else {
                    setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

                }

           
                
               /* $("#ddlList option[value='jquery']").attr("disabled", "disabled");*/
            }
        },
        complete: function () {
            setControlId.val(setId);
            setControlId.select2();

        }
    });

}


function _GetExpenseField_ByExpenseType(setControlId, bindId, bindName, id, setId) {
   
    $.ajax({
        url: '/CommonDataLoad/GetExpenseField_ByExpenseType',
        dataType: 'json',
        type: "Get",
        data: { id: id },
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select  ---</option>").val(0));
            for (var i = 0; i < result.length; i++) {
                setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

            }
        },
        complete: function () {
            
            setControlId.val(setId);
            setControlId.select2();

        }
    });

}


function _getArea_ByZoneId_Active(setControlId, bindId, bindName,id) {
    $.ajax({
        url: '/CommonDataLoad/GetArea_ByZoneId_Active',
        dataType: 'json',
        type: "Get",
        data: { id : id},
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select Area ---</option>").val(""));
            for (var i = 0; i < result.length; i++) {
                setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

            }
        },
        complete: function () {
            setControlId.select2();
        }
    });

}


function _getArea_ByZoneId_All(setControlId, bindId, bindName, id, setId) {
    $.ajax({
        url: '/CommonDataLoad/GetArea_ByZoneId_All',
        dataType: 'json',
        type: "Get",
        data: { id: id },
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select Area ---</option>").val(""));
            for (var i = 0; i < result.length; i++) {
                var data = result[i][bindName];
                var arr = data.split('(');


                if (arr[1] == 'Inactive)') {
                    setControlId.append($("<option disabled></option>").val(result[i][bindId]).html(result[i][bindName]));

                }
                else {
                    setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

                }

            }
        },
        complete: function () {
            setControlId.val(setId);
            setControlId.select2();
        }
    });

}

function _getDistrict_ByDivision_Active(setControlId, bindId, bindName, id) {
    $.ajax({
        url: '/CommonDataLoad/GetDistrict_ByDivision_Active',
        dataType: 'json',
        type: "Get",
        data: { id: id },
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select District ---</option>").val(0));
            for (var i = 0; i < result.length; i++) {
                setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

            }
        },
        complete: function () {
            setControlId.select2();
        }
    });

}


function _getThana_ByDistrict_Active(setControlId, bindId, bindName, id) {
    $.ajax({
        url: '/CommonDataLoad/GetThana_ByDistrict_Active',
        dataType: 'json',
        type: "Get",
        data: { id: id },
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select District ---</option>").val(0));
            for (var i = 0; i < result.length; i++) {
                setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

            }
        },
        complete: function () {
            setControlId.select2();
        }
    });

}

function _getArea_ByZoneId_Active_SetValue(setControlId, bindId, bindName, id, setId) {
    $.ajax({
        url: '/CommonDataLoad/GetArea_ByZoneId_Active',
        dataType: 'json',
        type: "Get",
        data: { id: id },
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select Area ---</option>").val(0));
            for (var i = 0; i < result.length; i++) {
                setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

            }
        },
        complete: function () {
            setControlId.val(setId);
            setControlId.select2();

        }
    });

}

function _getTerritory_ByAreaId_Active(setControlId, bindId, bindName, id) {
    $.ajax({
        url: '/CommonDataLoad/GetTerritory_ByAreaId_Active',
        dataType: 'json',
        type: "Get",
        data: { id: id },
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select Territory ---</option>").val(0));
            for (var i = 0; i < result.length; i++) {
                setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

            }
        },
        complete: function () {
            setControlId.select2();
        }
    });

}


function _getTerritory_ByAreaId_All(setControlId, bindId, bindName, id, setId) {
    $.ajax({
        url: '/CommonDataLoad/GetTerritory_ByAreaId_All',
        dataType: 'json',
        type: "Get",
        data: { id: id },
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select Territory ---</option>").val(0));
            for (var i = 0; i < result.length; i++) {
                var data = result[i][bindName];
                var arr = data.split('(');


                if (arr[1] == 'Inactive)') {
                    setControlId.append($("<option disabled></option>").val(result[i][bindId]).html(result[i][bindName]));

                }
                else {
                    setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

                }

            }
        },
        complete: function () {
            setControlId.val(setId);
            setControlId.select2();
        }
    });

}
function _getTerritory_ByAreaId_Active_SetValue(setControlId, bindId, bindName, id,setId) {
    $.ajax({
        url: '/CommonDataLoad/GetTerritory_ByAreaId_Active',
        dataType: 'json',
        type: "Get",
        data: { id: id },
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select Territory ---</option>").val(0));
            for (var i = 0; i < result.length; i++) {
                setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

            }
        },
        complete: function () {
            setControlId.val(setId);
            setControlId.select2();

        }
    });

}

function _getMarket_ByTerritoryId_Active(setControlId, bindId, bindName, id) {
    $.ajax({
        url: '/CommonDataLoad/GetMarket_ByTerritoryId_Active',
        dataType: 'json',
        type: "Get",
        data: { id: id },
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select Market ---</option>").val(0));
            for (var i = 0; i < result.length; i++) {
                setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

            }
        },
        complete: function () {
            setControlId.select2();
        }
    });

}


function _getMarket_ByTerritoryId_All(setControlId, bindId, bindName, id, setId) {
    $.ajax({
        url: '/CommonDataLoad/GetMarket_ByTerritoryId_All',
        dataType: 'json',
        type: "Get",
        data: { id: id },
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select Market ---</option>").val(0));
            for (var i = 0; i < result.length; i++) {
                var data = result[i][bindName];
                var arr = data.split('(');


                if (arr[1] == 'Inactive)') {
                    setControlId.append($("<option disabled></option>").val(result[i][bindId]).html(result[i][bindName]));

                }
                else {
                    setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

                }

            }
        },
        complete: function () {
            setControlId.val(setId);
            setControlId.select2();
        }
    });

}

function _getMarket_ByTerritoryId_Active_SetValue(setControlId, bindId, bindName, id,setId) {
    $.ajax({
        url: '/CommonDataLoad/GetMarket_ByTerritoryId_Active',
        dataType: 'json',
        type: "Get",
        data: { id: id },
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select Market ---</option>").val(0));
            for (var i = 0; i < result.length; i++) {
                setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

            }
        },
        complete: function () {
            setControlId.val(setId);
            setControlId.select2();

        }
    });

}

// Doctor Designation

function _getDesignation_Active(setControlId, bindId, bindName) {
    $.ajax({
        url: '/CommonDataLoad/GetDesignation_Active',
        dataType: 'json',
        type: "Get",
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select Designation ---</option>").val(0));
            for (var i = 0; i < result.length; i++) {
                setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

            }
        },
        complete: function () {
            setControlId.select2();
        }
    });

}

// Doctor Speciality

function _getDoctorSpeciality_Active(setControlId, bindId, bindName) {
    $.ajax({
        url: '/CommonDataLoad/GetDoctorSpeciality_Active',
        dataType: 'json',
        type: "Get",
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select Speciality ---</option>").val(0));
            for (var i = 0; i < result.length; i++) {
                setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

            }
        },
        complete: function () {
            setControlId.select2();
        }
    });

}


function _getDoctorBrand_Active(setControlId, bindId, bindName) {
    $.ajax({
        url: '/CommonDataLoad/GetDoctorBrand_Active',
        dataType: 'json',
        type: "Get",
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select Brand ---</option>").val(0));
            for (var i = 0; i < result.length; i++) {
                setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

            }
        },
        complete: function () {
            setControlId.select2();
        }
    });

}

function _getInstitute_Active(setControlId, bindId, bindName) {
    $.ajax({
        url: '/CommonDataLoad/GetInstitute_Active',
        dataType: 'json',
        type: "Get",
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select Brand ---</option>").val(0));
            for (var i = 0; i < result.length; i++) {
                setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

            }
        },
        complete: function () {
            setControlId.select2();
        }
    });

}


function _getContactType_Active(setControlId, bindId, bindName) {
    $.ajax({
        url: '/CommonDataLoad/GetContactType',
        dataType: 'json',
        type: "Get",
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select Contact Type ---</option>").val(0));
            for (var i = 0; i < result.length; i++) {
                setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

            }
        },
        complete: function () {
            setControlId.select2();
        }
    });

}

function _getSpecialDay_Active(setControlId, bindId, bindName) {
    $.ajax({
        url: '/CommonDataLoad/GetSpecialDay_Active',
        dataType: 'json',
        type: "Get",
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select Contact Type ---</option>").val(0));
            for (var i = 0; i < result.length; i++) {
                setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

            }
        },
        complete: function () {
            setControlId.select2();
        }
    });

}

function _geStationType_Active(setControlId, bindId, bindName) {
    $.ajax({
        url: '/CommonDataLoad/GetStationType_Active',
        dataType: 'json',
        type: "Get",
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select Brand ---</option>").val(0));
            for (var i = 0; i < result.length; i++) {
                setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

            }
        },
        complete: function () {
            setControlId.select2();
        }
    });

}


function _getChamberType_Active(setControlId, bindId, bindName) {
    $.ajax({
        url: '/CommonDataLoad/GetChamberType_Active',
        dataType: 'json',
        type: "Get",
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select Chamber Type ---</option>").val(0));
            for (var i = 0; i < result.length; i++) {
                setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

            }
        },
        complete: function () {
            setControlId.select2();
        }
    });

}



function _geStationType_Active(setControlId, bindId, bindName) {
    $.ajax({
        url: '/CommonDataLoad/GetStationType_Active',
        dataType: 'json',
        type: "Get",
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select Brand ---</option>").val(0));
            for (var i = 0; i < result.length; i++) {
                setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

            }
        },
        complete: function () {
            setControlId.select2();
        }
    });

}

function _geStationType_Active(setControlId, bindId, bindName) {
    $.ajax({
        url: '/CommonDataLoad/GetStationType_Active',
        dataType: 'json',
        type: "Get",
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select Brand ---</option>").val(0));
            for (var i = 0; i < result.length; i++) {
                setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

            }
        },
        complete: function () {
            setControlId.select2();
        }
    });

}

function _getDoctorType_Active(setControlId, bindId, bindName) {
    $.ajax({
        url: '/CommonDataLoad/GetDoctorType_Active',
        dataType: 'json',
        type: "Get",
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select Brand ---</option>").val(0));
            for (var i = 0; i < result.length; i++) {
                setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

            }
        },
        complete: function () {
            setControlId.select2();
        }
    });

}


function _getDivision_Active_Active(setControlId, bindId, bindName) {
    $.ajax({
        url: '/CommonDataLoad/GetDivision_Active',
        dataType: 'json',
        type: "Get",
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select Division ---</option>").val(0));
            for (var i = 0; i < result.length; i++) {
                setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

            }
        },
        complete: function () {
            setControlId.select2();
        }
    });

}

function _getDoctorProgramType_Active(setControlId, bindId, bindName) {
    $.ajax({
        url: '/CommonDataLoad/GetProgramType_Active',
        dataType: 'json',
        type: "Get",
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select Program Type ---</option>").val(0));
            for (var i = 0; i < result.length; i++) {
                setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

            }
        },
        complete: function () {
            setControlId.select2();
        }
    });

}


function _getDoctorCustomer_Active(setControlId, bindId, bindName) {
    $.ajax({
        url: '/CommonDataLoad/GetDoctorCustomer_Active',
        dataType: 'json',
        type: "Get",
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select Customer ---</option>").val(0));
            for (var i = 0; i < result.length; i++) {
                setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

            }
        },
        complete: function () {
            setControlId.select2();
        }
    });

}


function _getExpenseType(setControlId, bindId, bindName, setId) {
    $.ajax({
        url: '/CommonDataLoad/GetExpenseType',
        dataType: 'json',
        type: "Get",
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select Expense Type ---</option>").val(0));
            for (var i = 0; i < result.length; i++) {
                setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

            }
        },
        complete: function () {
            
            setControlId.val(setId);
           setControlId.select2();
        }
    });

}


// Doctor Degree
function _getDegree_Active(setControlId, bindId, bindName) {
    $.ajax({
        url: '/CommonDataLoad/GetDegree_Active',
        dataType: 'json',
        type: "Get",
        async: true,
        success: function (data) {
            var result = JSON.parse(data);
            setControlId.empty();
            setControlId.append($("<option>--- Select Degree ---</option>").val(0));
            for (var i = 0; i < result.length; i++) {
                setControlId.append($("<option></option>").val(result[i][bindId]).html(result[i][bindName]));

            }
        },
        complete: function () {
            setControlId.select2();
        }
    });
}

// 