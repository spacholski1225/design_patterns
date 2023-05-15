using Strategy.Files;

var csvFile = new CsvFile();
var jsonFile = new JsonFile();
var xmlFile = new XmlFile();

csvFile.ReadFile();
csvFile.SaveFile();