$(document).ready(function () {
    $('#idTable').DataTable({
        "ajax": {
            /*url: "https://pokeapi.co/api/v2/pokemon/",*/
            dataSrc: 'results',
            dataType: "JSON"
        },
        dom: 'Bfrtip',
        buttons: [
            'copy', 'csv', 'excel', 'pdf', 'print'
        ],
        "columns": [{
            "data": "id",
            "render": function (data, type, row, meta) {
                return meta.row + meta.settings._iDisplayStart + 1;
            }
        },
        {
            "data": "name"
        },
        {
            "data": "url",
            "render": function (data, type, row) {
                return `<button class="btn btn-primary" onclick="detailModal('${data}')" data-bs-toggle="modal" data-bs-target="#modalDetailPoke">Detail</button>`;
            }
        }
        ]
    });

});