
console.log("Module File");

function squareTheCube()
{
    var number = $("#number").val();
    var cubed = cube(number);
    return cubed * cubed;
}

import * as counter from './ExportFile.js'
import cube from './DefaultExportFile.js'

    $("#myButton").click(function () {
        console.log(squareTheCube());
    });
    $("#counterIncrement").click(function () {
        console.log("Before: " + counter.counter);
        counter.increment();
        console.log("After: " + counter.counter);
    });
    $("#counterDecrement").click(function () {
        console.log("Before: " + counter.counter);
        counter.decrement();
        console.log("After: " + counter.counter);
    });
