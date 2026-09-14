Student student1 = new("Student 1");
Student student2 = new("Student 2");
Student student3 = new("Student 3");
Course english = new("English", 2);



english.Enroll(student1);
english.Enroll(student1);
english.Enroll(student2);

english.Remove(student3);
english.Remove(student2);




english.RollCall();


