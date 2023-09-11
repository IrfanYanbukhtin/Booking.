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
    var hotelCount = $("#hotelCount").val();
    $.ajax({
        url: "/stays/loadHotels?skip=" + skip,
        type: "GET",
        success: function (response) {
            $("#hotelrow").append(response);
            skip += 4;

            if (skip >= hotelCount)
                $("#loadMore").remove();

            console.log(response);
        },
        error: function (xhr) {

        }
    });
})

})(jQuery);	