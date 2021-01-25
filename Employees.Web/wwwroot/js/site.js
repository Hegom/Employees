document.getElementById("getEmployeesButton").addEventListener("click", async function (event) {
    var employeeId = document.getElementById("employeeInput").value;
    await fetchEmployees(employeeId);
});

const employeeApi = 'http://localhost:50266/api/Employee/';

async function fetchEmployees(employeeId) {
    const response = await fetch(`${employeeApi}${employeeId}`);

    if (!response.ok) {
        const message = `An error has occured: ${response.status}`;
        alert(`Error: ${message}`)
        throw new Error(message);
    }

    if (response.status == 204) {
        $('#employeesTable').bootstrapTable('load', []);
    }
    else {
        const employees = await response.json();
        $('#employeesTable').bootstrapTable({
            data: employees
        });
        $('#employeesTable').bootstrapTable('load', employees);
    }
}