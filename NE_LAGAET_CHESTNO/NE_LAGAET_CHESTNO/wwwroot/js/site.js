function Search() {
    $.ajax({
        type: "PosT",
        url: "/Home/AdvertSearch",
        data: {
            "Id": document.getElementById("Id").value,
            "request": document.getElementById("request").value,
        },
        success: function (response) {
            if (response.isRedirect) {
                window.location.href = response.redirectUrl;
            }
            const adverts = document.getElementById("adverts");
            while (adverts.lastElementChild)
                adverts.removeChild(adverts.lastElementChild)
            var cases = [2, 0, 1, 1, 1, 2];
            var Monthes = ["месяц", "месяца", "месяцев"];
            response.forEach(function (data, i, response) {
                var advert = document.createElement("div");
                advert.className = "advert";
                var month = Monthes[data.timeOfUse % 100 > 4 && data.timeOfUse % 100 < 20 ? 2 : cases[(advert.timeOfUse % 10 < 5) ? data.timeOfUse % 10 : 5]];
                if (data.other != null) {
                    advert.innerHTML = `<div class="advert_title">` +
                        `<p>МЕНЯЮ: ` + data.phone.brand + ` ` + data.phone.model + ` НА: ` + data.replacementPhone + `</p>` +
                        `</div>` +
                        `<div class="advert_description">` +
                        `<p>ОС: ` + data.phone.os + `, прошивка: ` + data.phone.firmware + `, дисплей: ` + data.phone.display + `, ёмкость батареи: ` + data.phone.batteryCapacity + ` mAh, мощность зарядки: ` + data.phone.chargePower + ` Вт, ОЗУ: ` + data.phone.ram + ` GB, ПЗУ: ` + data.phone.rom + ` GB, цвет: ` + data.phone.color + `</p>` +
                        `<p>Прочее: ` + data.other + `</p>` +
                        `<p>Время пользования: ` + data.timeOfUse + ` ` + month + `</p>` +
                        `<button id="response"><a href="/Home/Advertisement_Page/` + data.id + `">Откликнуться</a></button>` +
                        `</div>`
                }
                else {
                    advert.innerHTML = `<div class="advert_title">` +
                        `<p>МЕНЯЮ: ` + data.phone.brand + ` ` + data.phone.model + ` НА: ` + data.replacementPhone + `</p>` +
                        `</div>` +
                        `<div class="advert_description">` +
                        `<p>ОС: ` + data.phone.os + `, прошивка: ` + data.phone.firmware + `, дисплей: ` + data.phone.display + `, ёмкость батареи: ` + data.phone.batteryCapacity + ` mAh, мощность зарядки: ` + data.phone.chargePower + ` Вт, ОЗУ: ` + data.phone.ram + ` GB, ПЗУ: ` + data.phone.rom + ` GB, цвет: ` + data.phone.color + `</p>` +
                        `<p>Время пользования: ` + data.timeOfUse + ` ` + month + `</p>` +
                        `<button id="response"><a href="/Home/Advertisement_Page/` + data.id + `">Откликнуться</a></button>` +
                        `</div>`
                }
                adverts.appendChild(advert);
            });
        },

        failure: function (response) {

        },

        error: function (response) {

        }
    });
}
