// Method that is called from gcScriptManager
function SelectionTextBox_LoadControl(strGuid) {

    // Gets Window
    var myWindow = Forms_GetWindowByDataId(strGuid);

    // Gets DIV Container
    var myContainer = Web_GetElementByDataId(strGuid, null);

    // Gets TextBox
    var myControl = Web_GetTargetElementByDataId(strGuid, null);

    // Create EventListener
    var myEventListener = function(e) { SelectionTextBox_Focus(strGuid, myControl, myWindow); };

    // Listen
    SelectionTextBox_AttachEvent(myControl, "focus", myEventListener, false);

    return;
}

function SelectionTextBox_CreateGuid() {
    var myGuidPart = function() { return (((1 + Math.random()) * 0x10000) | 0).toString(16).substring(1); };
    return (myGuidPart() + myGuidPart() + "-" + myGuidPart() + "-" + myGuidPart() + "-" + myGuidPart() + "-" + myGuidPart() + myGuidPart() + myGuidPart());
}

// Called whenever the textbox got focus
function SelectionTextBox_Focus(strGuid, objInput, objWindow) {

    // Get SelectAllTextOnEnter Flag
    var mySelectAllTextOnEnter = Data_GetAttribute(strGuid, "SelectAllTextOnEnter");

    if (mySelectAllTextOnEnter == 1) {
        objInput.select();
    }

}

//***e.g. AttachEvent(window,'load',MyFunctionNameWithoutParenthesis,false);
//http://phrogz.net/JS/AttachEvent_js.txt
function SelectionTextBox_AttachEvent(obj, evt, fnc, useCapture) {
    if (!useCapture) useCapture = false;
    if (obj.addEventListener) {
        obj.addEventListener(evt, fnc, useCapture);
        return true;
    } else if (obj.attachEvent) return obj.attachEvent("on" + evt, fnc);
    else {
        MyAttachEvent(obj, evt, fnc);
        obj['on' + evt] = function() { MyFireEvent(obj, evt) };
    }
}
