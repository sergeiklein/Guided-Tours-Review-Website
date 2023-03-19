// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function hideLink() {
    var w = document.getElementById("add_dest_button");
    var x = document.getElementById("all_reviews_button");
    var y = document.getElementsByClassName("delete_buttons");
    var z = document.getElementsByClassName("edit_buttons");

    if (x.style.display === "none") {
        w.style.visibility = "visible"
        x.style.display = "inline-flex";
        Array.prototype.forEach.call(y, function (el) {
            el.style.display = "inline-flex";
        });
        Array.prototype.forEach.call(z, function (el) {
            el.style.display = "inline-flex";
        });
    } else {
        w.style.visibility = "hidden";
        x.style.display = "none";
        Array.prototype.forEach.call(y, function (el) {
            el.style.display = "none";
        });
        Array.prototype.forEach.call(z, function (el) {
            el.style.display = "none";
        });

    }
}

//var average = items.Reviews.Average(i => i.Rating);
//var floorplanSettings = @Html.Raw(Json.Encode(Model.Reviews));
//var userObj = @Html.Raw(Json.Encode(Model));
//var userJsonObj = '@Html.Raw(Json.Encode(Model))';
//document.getElementById("dest_row_tour_price_1").innerHTML = average;


//    var background = document.getElementById("background");
//    var currentPos = 0;
//    var images = ["https://localhost:7186/Images/Tokyo1.jpg", "https://media.wired.com/photos/5cdefb92b86e041493d389df/1:1/w_988,h_988,c_limit/Culture-Grumpy-Cat-487386121.jpg", "https://localhost:7186/Images/Tokyo1.jpg", "https://media.wired.com/photos/5cdefb92b86e041493d389df/1:1/w_988,h_988,c_limit/Culture-Grumpy-Cat-487386121.jpg"], i = 0;

//    function changeimage()
//    {
//        if (++currentPos >= images.length)
//    currentPos = 0;

//    background.style.backgroundImage = "url(" + images[currentPos] + ")";
//    }
//setInterval(changeimage, 3000);

//var textLength = $('#dest_row_tour_description_1').text().length
//document.getElementById("dest_row_tour_price_1").innerHTML = textLength;

//var dest_count = document.querySelectorAll('.dest_row_tour_price').length;
//document.getElementById("dest_row_tour_duration_1").innerHTML = dest_count;
//const matches = element.getElementByClassName();
//matches.
    //for (i = 1; i < dest_count+1; i++)
    //{
    //    textLength = $('#dest_row_tour_description_' + i).text().length;
    //    document.getElementById("dest_row_tour_price_" + i).innerHTML = textLength;
    //    if (textLength > 300)
    //    {
    //        document.getElementById("dest_row_tour_description_" + i).innerHTML = document.getElementById("dest_row_tour_description_" + i).innerHTML.slice(0, 300);
    //    }
    //}
//if ($('#dest_row_tour_description_1')[0].scrollWidth > $('#dest_row_tour_description_1').innerWidth()) {
//    document.getElementById("dest_row_tour_description_1").innerHTML += "...";
/*}*/


