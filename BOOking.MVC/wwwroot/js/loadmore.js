/*------------------------------------
        Load More
--------------------------------------*/
var skip = 4;
$(document).on('click', '#loadMore', function () {
    var airportCount = $("#airportCount").val();
    $.ajax({
        url: "/rental/LoadAirports?skip=" + skip,
        type: "GET",
        success: function (response) {
            $("#flight-nearby").append(response);
            skip += 2;

            if (skip >= airportCount)
                $("#loadMore").remove();

            console.log(response);
        },
        error: function (xhr) {

        }
    });
});