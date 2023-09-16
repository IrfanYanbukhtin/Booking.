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

