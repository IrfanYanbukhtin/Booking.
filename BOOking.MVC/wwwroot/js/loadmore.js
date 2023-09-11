(function ($) {
    "use strict";  
/*------------------------------------
        Load More
--------------------------------------*/
var skip = 4;
$(document).on('click', '#loadMore', function () {
    var airportCount = $("#airportCount").val();
    $.ajax({
        url: "/rental/loadAirport?skip=" + skip,
        type: "GET",
        success: function (response) {
            $("#flight-to").append(response);
            skip += 2;

            if (skip >= airportCount)
                $("#loadMore").remove();

            console.log(response);
        },
        error: function (xhr) {

        }
    });
});

/*------------------------------------
        Load More Hotel
--------------------------------------*/
var skip = 4;
$(document).on('click', '#loadMore', function () {
    var teacherCount = $("#teacherCount").val();
    $.ajax({
        url: "/teacher/loadTeachers?skip=" + skip,
        type: "GET",
        success: function (response) {
            $("#teacherRow").append(response);
            skip += 4;

            if (skip >= teacherCount)
                $("#loadMore").remove();

            console.log(response);
        },
        error: function (xhr) {

        }
    });
})

})(jQuery);	