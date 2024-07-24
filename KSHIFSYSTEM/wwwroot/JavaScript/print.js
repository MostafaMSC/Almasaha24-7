function print(Area2) {
    var content = document.getElementById(Area2).innerHTML;
    var printWindow = window.open('', '', 'width=1300,height=1100');
    printWindow.document.open();
    printWindow.document.write('<html><head><style>');
    printWindow.document.write('.print-table { border-collapse: collapse; margin: 0; width: 100%; font-size: 16px; border-spacing: 0; }');
    printWindow.document.write('.print-table th, .print-table td { border: 1px solid black; margin: 0; text-align: center; font-size: 16px; padding: 0; }');
    printWindow.document.write('body { direction: rtl; font-size: 16px; }');
    printWindow.document.write('</style></head><body>');
    printWindow.document.write('<div class="print-table">' + content + '</div>');
    printWindow.document.write('</body></html>');
    printWindow.document.close();
    printWindow.print();
}
