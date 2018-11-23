// adds a new note 
function AddNote(sectionId, controlName) {
    // get the field value
    var noteText = $(controlName).val();
    
    var itemList = [];
    // decode the JSON data in the hidden control
    var existingData = JSON.parse($("#grantNotesJson").val());

    // create a new record using the field values entered
    var item = {
        SectionId: sectionId,
        Text: noteText
    }

    // check if this is the first record being inserted into the control
    if (existingData == []) {
        // push it into the blank array
        itemList.push(item);
        // encode the newly created array and save the data to the hidden control
        $("#grantNotesJson").val(JSON.stringify(itemList));
    }
    else {
        // add the new entry to the existing decoded JSON data
        existingData.push(item);
        // encode the updated array and save the data to the hidden control
        $("#grantNotesJson").val(JSON.stringify(existingData));
    }

    // clear the control
    $(controlName).val("");
}