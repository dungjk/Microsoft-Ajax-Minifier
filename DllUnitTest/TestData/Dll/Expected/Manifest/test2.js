﻿(function(window,document,undefined){function myFunc(param){alert(param+foo+bar+42),arf(param,foo+bar,bar-foo)}function arf(one,two,three,four){one==undefined&&(one="undefined"),two+=four,foobar(one,two,three),alert("called foobar"),document.location="#arf"}var foo,bar=153;window.myFunc=myFunc})(window,document)