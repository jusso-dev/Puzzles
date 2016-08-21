$(document)
    .ready(function() {
        $("#getPuzzleBtn")
            .click(function() {
                $.ajax({
                        url: "http://localhost:49770/api/Puzzles",
                        dataType: "json"
                    })
                    .success(function(data) {
                        try {
                            $("#ul").append(JSON.stringify(data));
                        } catch (ex) {
                            alert("Ajax call failed " + ex.message);
                        }

                        $("#clearPuzzleBtn").click(function () {
                             $("#ul").empty();
                        });
                    });
            });
   });
  