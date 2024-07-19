$(document).ready(function() {
    $('#your-tree').jstree({
        'core': {
            'check_callback': true,
            'data': [
                // your tree data here
            ]
        }
    }).on('before_close.jstree', function(e, data) {
        if (data.node.id === 'your_specific_node_id') {
            return false; // Prevents collapsing
        }
    });
});