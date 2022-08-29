var trangthais = document.querySelectorAll('.trangthai')
for (var i = 0; i < trangthais.length; i++) {
    if (trangthais[i].innerHTML == '1         ') {
        trangthais[i].innerHTML = 'Chưa cập nhật'
        trangthais[i].classList.add('chuacapnhat')
    }
    else if (trangthais[i].innerHTML == '0         ') {
        trangthais[i].innerHTML = 'Đã cập nhật'
        trangthais[i].classList.add('dacapnhat')
    }
    else {
        trangthais[i].innerHTML = 'CVE'
        trangthais[i].classList.add('chuacve')
    }
}

var stts = document.querySelectorAll('.stt')
for (var i = 0; i < stts.length; i++) {
    stts[i].innerHTML = (i+1).toString();
}