$("#submitBtn")
    .click(function () {
       $("#divResults").load("/AdminPuzzleProducts/Index");
    });

$("#clearPuzzleBtn")
    .click(function () {
        $("#divResults").empty();
    });