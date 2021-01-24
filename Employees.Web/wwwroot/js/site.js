document.getElementById("getEmployeesButton").addEventListener("click", function (event) {
    var employeeId = document.getElementById("employeeInput").value;

    fetch(`http://localhost:50266/api/Employee/${employeeId}`)
        .then((response) => {           
            if (response.status == 400) {
                alert(`Error: ${response.statusText}`)
            }
            if (response.status != 204) {
                return response.json();
            }
            return [];
        })
        .then((data) => {
            console.log(data);
            $('#employeesTable').bootstrapTable({
                data: data
            });
            // Refresh
            $('#employeesTable').bootstrapTable('load', data);
        })
        .catch((error) => console.log(error))
});
