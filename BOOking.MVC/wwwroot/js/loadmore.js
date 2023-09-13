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
$(document).on('click', '#loadHotel', function () {
    var hotelCount = $("#hotelCount").val();
    $.ajax({
        url: "/stays/loadHotels?skip=" + skip,
        type: "GET",
        success: function (response) {
            $("#hotelrow").append(response);
            skip += 4;

            if (skip >= hotelCount)
                $("#loadHotel").remove();

            console.log(response);
        },
        error: function (xhr) {

        }
    });
})

    /*------------------------------------
            Load More Gateway
    --------------------------------------*/
    var skip = 4;
    $(document).on('click', '#loadGatesay', function () {
        var gatewayCount = $("#gatewayCount").val();
        $.ajax({
            url: "/gateway/loadGateways?skip=" + skip,
            type: "GET",
            success: function (response) {
                $("#gatewayRow").append(response);
                skip += 4;

                if (skip >= gatewayCount)
                    $("#loadGateway").remove();

                console.log(response);
            },
            error: function (xhr) {

            }
        });
    })

 

})(jQuery);	