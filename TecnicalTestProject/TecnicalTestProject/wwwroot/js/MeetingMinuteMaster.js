
var dataTable;
$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/Home/GetMasterDetails' },
        "columns": [
            { data: 'sl', title: 'Sl No',"width": "10%" },
            { data: 'name',title:'Interested Product/Service', "width": "30%" },
            { data: 'unit', title: 'Unit', "width": "15%" },
            { data: 'quantity', title: 'Quantity',  "width": "15%" },
          
            {
                data: 'id',
                "render": function (data) {
                    return ``
                },
                "width": "25%"
            }
        ]
    });
}


function Delete(url) {
    Swal.fire({
        title: "Are you sure?",
        text: "You won't be able to revert this!",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Yes, delete it!"
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    dataTable.ajax.reload();
                    toastr.success(data.message);
                }
            });
        }
    });

}
function check(val) {
    if (val == true) {
        return 'Approved'
    } else {
        return 'Rejected'
    }
}

