$(document).ready(function () {
    $("#form1").submit(function (e) {
        e.preventDefault();
        calculate();
    });
});

function calculate() {

    if ($("#form1").valid())
    {
        var calculationUrl;
        var Data = $("#req_1").val();
        switch ($("input[name='radio_1']:checked").val()) {
            case "val1":
                calculationUrl = "http://localhost:58059/api/calculator/GetAllNumbers/" + Data;
                break;
            case "val2":
                calculationUrl = "http://localhost:58059/api/calculator/GetOddNumbers/" + Data;
                break;
            case "val3":
                calculationUrl = "http://localhost:58059/api/calculator/GetEvenNumbers/" + Data;
                break;
            case "val4":
                calculationUrl = "http://localhost:58059/api/calculator/getmultiplenumbers/" + Data;
                break;
            case "val5":
                calculationUrl = "http://localhost:58059/api/calculator/GetFibonacchiNumbers/" + Data;
                break;
        }
        $.ajax({
            type: "GET", //GET or POST or PUT or DELETE verb
            url: calculationUrl, // Location of the service
            contentType: "application/json; charset=utf-8", // content type sent to server
            dataType: "json", //Expected data format from server
            processdata: true, //True or False
            success: function (msg) {//On Successfull service call
                ServiceSucceeded(msg);
            },
            error: ServiceFailed// When Service call fails
        });
    }
};
function ServiceSucceeded(result) {
    $("#txtresult").val(result);
}

function ServiceFailed(xhr) {
    alert("There was an error in the application");
    /*
    if (xhr.responseText) {
        var err = xhr.responseText;
        if (err)
            alert(err);
        else
            alert("Unknown server error.");
    }*/
    return;
};