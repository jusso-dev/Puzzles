﻿$(document).ready(function ()

{
    $("#getPuzzleBtn").click(function ()

    {
        $.ajax({ url: "http://localhost:49770/api/Puzzles", dataType: "json" }).success

            (function (a) {
                try { $("#ul").append(JSON.stringify(a)) } catch (a)

                { alert("Ajax call failed " + a.message) }

                $("#clearPuzzleBtn").click(function () { $("#ul").empty() })
            })
    })
});