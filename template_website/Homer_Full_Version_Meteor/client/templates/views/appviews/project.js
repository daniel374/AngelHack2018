Template.project.onRendered(function(){

    /**
     * Options for Line chart
     */
    var lineData = {
        labels: ["January", "February", "March", "April"],
        datasets: [
            {
                label: "Example dataset",
                backgroundColor: "rgba(98,203,49,0.5)",
                borderColor: "rgba(98,203,49,0.7)",
                pointBackgroundColor: "rgba(98,203,49,1)",
                pointBorderColor: "#fff",
                pointHoverBackgroundColor: "#fff",
                pointHoverBorderColor: "rgba(26,179,148,1)",
                data: [17,21,19,24]
            }
        ]
    };

    var lineOptions = {
        responsive: true,
        legend: {
            display: false
        }
    };

    var ctx = document.getElementById("lineOptions").getContext("2d");
    new Chart(ctx, {type: 'line', data: lineData, options:lineOptions});

});