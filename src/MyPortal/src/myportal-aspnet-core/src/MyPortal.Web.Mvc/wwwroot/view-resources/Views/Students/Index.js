(function ($) {
    var _studentService = abp.services.app.student,
        l = abp.localization.getSource('MyPortal'),
        _$modal = $('#StudentCreateModal'),
        _$form = _$modal.find('form'),
        _$table = $('#StudentsTable');

    var _$studentsTable = _$table.DataTable({
        paging: true,
        serverSide: true,
        ajax: function (data, callback, settings) {
            var filter = $('#StudentSearchForm').serializeFormToObject(true);
            filter.maxResultCount = data.length;
            filter.skipCount = data.start;

            abp.ui.setBusy(_$table);
            _studentService.getAll(filter).done(function (result) {
                callback({
                    recordsTotal: result.totalCount,
                    recordsFiltered: result.totalCount,
                    data: result.items
                });
            }).always(function () {
                abp.ui.clearBusy(_$table);
            });
        },
        buttons: [
            {
                name: 'refresh',
                text: '<i class="fas fa-redo-alt"></i>',
                action: () => _$studentsTable.draw(false)
            }
        ],
        responsive: {
            details: {
                type: 'column'
            }
        },
        columnDefs: [
            {
                targets: 0,
                className: 'control',
                defaultContent: '',
            },
            {
                targets: 1,
                data: 'id',
                sortable: false
            },
            {
                targets: 2,
                data: 'age',
                sortable: false
            },
            {
                targets: 3,
                data: 'address',
                sortable: false,
            },
            {
                targets: 4,
                data: null,
                sortable: false,
                autoWidth: false,
                defaultContent: '',
                render: (data, type, row, meta) => {
                    return [
                        `   <button type="button" class="btn btn-sm bg-secondary edit-student" data-student-id="${row.id}" data-toggle="modal" data-target="#StudentEditModal">`,
                        `       <i class="fas fa-pencil-alt"></i> ${l('Edit')}`,
                        '   </button>',
                        `   <button type="button" class="btn btn-sm bg-danger delete-student" data-student-id="${row.id}" data-tenancy-name="${row.name}">`,
                        `       <i class="fas fa-trash"></i> ${l('Delete')}`,
                        '   </button>'
                    ].join('');
                }
            }
        ]
    });

    _$form.find('.save-button').click(function (e) {
        e.preventDefault();

        if (!_$form.valid()) {
            return;
        }

        var student = _$form.serializeFormToObject();

        abp.ui.setBusy(_$modal);

        _studentService
            .create(student)
            .done(function () {
                _$modal.modal('hide');
                _$form[0].reset();
                abp.notify.info(l('SavedSuccessfully'));
                _$studentsTable.ajax.reload();
            })
            .always(function () {
                abp.ui.clearBusy(_$modal);
            });
    });

    $(document).on('click', '.delete-student', function () {
        var studentId = $(this).attr('data-student-id');
        var tenancyName = $(this).attr('data-tenancy-name');

        deleteStudent(studentId, tenancyName);
    });

    $(document).on('click', '.edit-student', function (e) {
        var studentId = $(this).attr('data-student-id');

        abp.ajax({
            url: abp.appPath + 'Students/EditModal?studentId=' + studentId,
            type: 'POST',
            dataType: 'html',
            success: function (content) {
                $('#StudentEditModal div.modal-content').html(content);
            },
            error: function (e) { }
        });
    });

    abp.event.on('student.edited', (data) => {
        _$studentsTable.ajax.reload();
    });

    function deleteStudent(studentId, tenancyName) {
        abp.message.confirm(
            abp.utils.formatString(
                l('AreYouSureWantToDelete'),
                tenancyName
            ),
            null,
            (isConfirmed) => {
                if (isConfirmed) {
                    _studentService
                        .delete({
                            id: studentId
                        })
                        .done(() => {
                            abp.notify.info(l('SuccessfullyDeleted'));
                            _$studentsTable.ajax.reload();
                        });
                }
            }
        );
    }

    _$modal.on('shown.bs.modal', () => {
        _$modal.find('input:not([type=hidden]):first').focus();
    }).on('hidden.bs.modal', () => {
        _$form.clearForm();
    });

    $('.btn-search').on('click', (e) => {
        _$studentsTable.ajax.reload();
    });

    $('.btn-clear').on('click', (e) => {
        $('input[name=Keyword]').val('');
        $('input[name=IsActive][value=""]').prop('checked', true);
        _$studentsTable.ajax.reload();
    });

    $('.txt-search').on('keypress', (e) => {
        if (e.which == 13) {
            _$studentsTable.ajax.reload();
            return false;
        }
    });
})(jQuery);
