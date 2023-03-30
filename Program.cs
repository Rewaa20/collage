using collage;
//create contact obj data base
var db = new ContactDb();

//ADD ROW
db.Students.Add(
	new Std { id=1 , name="omar", department="IT" }
	);
await db.SaveChangesAsync();

//ADD MULTIPLE ROWS
db.Students.AddRange(new Std[]  {
	new Std {id=2, name="rewaa" , department="engineering"},
	new Std {id=3, name="suhibe" , department="midecen"}
});
await db.SaveChangesAsync();

//UPDATE
var ToUpdate = db.Students.FirstOrDefault(c=>c.id == 1);
ToUpdate.name = "Omar";
await db.SaveChangesAsync();

//DELETE
var ToDelete = db.Students.FirstOrDefault(c => c.id == 2);
db.Students.Remove(ToUpdate);
await db.SaveChangesAsync();