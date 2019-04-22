function searchPeople() {
    var search = $("#userID").val();

    $.ajax({
        url: "Search",
        data: { searchGuid: search.toString() }
    }).done(function (data) {
        $("#personId").val(data.PersonId);
        $("#firstName").val(data.FirstName);
        $("#lastName").val(data.LastName);
        $("#gender").val(data.Gender);
        $("#email").val(data.Email);
        $("#dateCreated").val(data.DateCreated);
        $("#phoneNumber").val(data.PhoneNumber);
        
        if (data.PersonId == "00000000-0000-0000-0000-000000000000") {
            $("#CreateProfile").removeClass("hidden");
        }
        else {
            $("#Form").removeClass("hidden");
            ToJavaScriptDate();
        }
        
    });
}

function search() {

    var search = $("#userID").val();

    $.ajax({
        url: "Search",
        data: { searchGuid: search.toString() }
    }).done(function (data) {
        $("#personId").val(data.PersonId);
        if (data.PersonId == "00000000-0000-0000-0000-000000000000") {
            $("#CreateForm").removeClass("hidden");
        }
        else {
            $("#Success").removeClass("hidden");
        }
    });
}

function createPerson() {
    if (!$("#successMessage").is(":hidden")) {
        $("#successMessage").addClass("hidden");
    }

    if (!$("#errorMessage").is(":hidden")) {
        $("#errorMessage").addClass("hidden");
    }

    var firstName = $("#firstName").val();
    var lastName = $("#lastName").val();
    var gender = $("#gender").val();
    var email = $("#email").val();
    var phoneNumber = $("#phoneNumber").val();
    
    if (firstName == "") {
        $("#errorMessage").removeClass("hidden").text('Please enter a first name');
        return ("");
    }

    if (lastName == "") {
        $("#errorMessage").removeClass("hidden").text('Please enter a last name');
        return ("");
    }

    if (email == "") {
        $("#errorMessage").removeClass("hidden").text('Please enter an email');
        return ("");
    }

   
    $.ajax({
        url: "CreatePerson",
        dataType: "json",
        data: {
            FirstName: firstName,
            LastName: lastName,
            Gender: gender,
            Email: email,
            PhoneNumber: phoneNumber
        }
    }).done(function (data) {
        if (data) {
            $("#successMessage").removeClass("hidden").text('Successfully Updated');
            $("#Success").removeClass("hidden");
            $("#CreateForm").addClass("hidden");
        }
        else {
            $("#errorMessage").removeClass("hidden").text('Error Occurred');
        }
    });
}



function updatePerson() {
    if (!$("#successMessage").is(":hidden")) {
        $("#successMessage").addClass("hidden");
    }

    if (!$("#errorMessage").is(":hidden")) {
        $("#errorMessage").addClass("hidden");
    }

    var personId = $("#personId").val();
    var firstName = $("#firstName").val();
    var lastName = $("#lastName").val();
    var gender = $("#gender").val();
    var email = $("#email").val();
    var phoneNumber = $("#phoneNumber").val();
    
    if (firstName == "") {
        $("#errorMessage").removeClass("hidden").text('Please enter a first name');
        return ("");
    }

    if (lastName == "") {
        $("#errorMessage").removeClass("hidden").text('Please enter a last name');
        return ("");
    }

    if (email == "") {
        $("#errorMessage").removeClass("hidden").text('Please enter an email address');
        return ("");
    }

    $.ajax({
        url: "UpdatePerson",
        dataType: "json",
        data: {
            PersonId: personId,
            FirstName: firstName,
            LastName: lastName,
            Gender: gender,
            Email: email,
            PhoneNumber: phoneNumber
        }
    }).done(function (data) {
        $("Form").submit(function (f) {
            f.preventDefault();
        });
        if (data) {
            $("#successMessage").removeClass("hidden").text('Successfully Updated');
        }
        else {
            $("#errorMessage").removeClass("hidden").text('Error Occured');
        }
    });
}

//The ToJavaScriptDate() function accepts a value in \/Date(ticks)\/ format and returns a date string in MM/dd/yyyy format. 
// Function found on - https://stackoverflow.com/questions/27314663/asp-net-parse-datetime-result-from-ajax-call-to-javascript-dat
function ToJavaScriptDate() {
    var pattern = /Date\(([^)]+)\)/;
    var results = pattern.exec($("#dateCreated").val());
    var dt = new Date(parseFloat(results[1]));
    return $("#dateCreated").val((dt.getMonth() + 1) + "/" + dt.getDate() + "/" + dt.getFullYear());
}