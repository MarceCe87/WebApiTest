/* 1. Define a prototype for a class named "Employee".
An employee has a first name, last name and a salary.
Provide a method for increasing their salary by 1,000
Provide a method for displaying the employee details */


function Employee(first, last, salary) {
    this.firstName = first;
    this.lastName = last;
    this.salary = salary;
}

Employee.prototype.increaseSalary  = function() {
    this.salary += 1000;
};

Employee.prototype.info = function() {
    console.log("Firstname: " + this.firstName);
    console.log("Lastname: " + this.lastName);
    console.log("Salary: " + this.salary);
};

/* 2. Write a function called "MultiplyBy" which will produce the following outputs when invoked:
console.log(mul(2)(3)(4)); // output : 24 
console.log(mul(4)(3)(4)); // output : 48 */

var mul = function MultiplyBy(x) {
    return function (y) { 
        return function (z) {  
            return x * y * z; 
        };
    };
};

/* 3. Write a function that accept a list of country names as input and returns the longest country name as output.
Sample function : Longest_Country_Name(["Australia", "Germany", "United States of America"])
Expected output : "United States of America" */

function Longest_Country_Name(countryNames) {
    var country = "";
    for (let i of countryNames) {
        if (i.length > country.length) country = i;
    }
    return country;
}

/* 4.  Write a function that removes items from a dropdown list.
Sample HTML file:
<!DOCTYPE html>
<html><head>
<meta charset=utf-8 />
<title>Remove items from a dropdown list</title>
</head><body><form>
<select id="colorSelect">
<option>Red</option>
<option>Green</option>
<option>White</option>
<option>Black</option>
</select>
<input type="button" onclick="removecolor()" value="Select and Remove">
</form></body></html>*/
 
 function removecolor() {
    var select = document.getElementById('colorSelect');

	for (i=0;i<select.length;  i++) {
	   if (select.options[i].value=='Red') {
		 select.remove(i);
	   }
}

/* 5. Write a JavaScript function to add rows to a table. 
Sample HTML file:
<!DOCTYPE html>
<html><head>
<meta charset=utf-8 />
<title>Insert row in a table</title>
</head><body>
<table id="sampleTable" border="1">
<tr><td>Row1 cell1</td>
<td>Row1 cell2</td></tr>
<tr><td>Row2 cell1</td>
<td>Row2 cell2</td></tr>
</table><br>
<input type="button" onclick="insert_Row()" value="Insert row"> 
</body></html> */

 function insert_Row() {
	 
	var tableRef = document.getElementById('sampleTable').getElementsByTagName('tbody')[0];
	var newRow   = tableRef.insertRow(tableRef.rows.length);
	var newCell  = newRow.insertCell(0);
	var newText  = document.createTextNode('Row3 cell1');
	newCell.appendChild(newText);
 }