using Factory.Files;
using Strategy;
using Strategy.Files;
using Strategy.Interfaces;

/*
var csvFile = new CsvFile();
var jsonFile = new JsonFile();
var xmlFile = new XmlFile();

csvFile.ReadFile();
csvFile.SaveFile();*/


var tempFile = new CustomFile(new CsvFileStrategy());