# Δημιουργία ξεχωριστών αρχείων βαθμολογίας και συγχώνευσή τους για το myschool.sch.gr

## 📝 Περιγραφή

Αυτή η εφαρμογή VB.NET επιτρέπει τη δημιουργία ξεχωριστών αρχείων Excel για την καταγραφή βαθμολογιών από πολλαπλούς καθηγητές και την τελική συγχώνευσή τους για μαζική εισαγωγή στο myschool.sch.gr, το ελληνικό σύστημα διαχείρισης σχολικών δεδομένων.

Η εφαρμογή απλοποιεί τη διαδικασία διαμοιρασμού φύλλων βαθμολογίας και της συλλογής τους από τη διοίκηση του σχολείου, μειώνοντας τα λάθη και τον χρόνο καταχώρησης.

## ⚙️ Χαρακτηριστικά

- Δημιουργία ξεχωριστών αρχείων Excel για κάθε καθηγητή, τμήμα και μάθημα.
- Συγχώνευση αρχείων Excel σε ένα ενιαίο αρχείο ανά τάξη για εισαγωγή στο myschool.sch.gr.

## 🚀 Τρόπος Χρήσης

1. Συμπληρώστε στα πεδία "Μάθημα", "Αρ. Μητρώου" και "Βαθμοί", τις αντίστοιχες διευθύνσεις στις καταστάσεις βαθμολογίας.
2. Επιλέξτε ως αρχείο εισόδου το φύλλο Excel  .xlsx που έχετε εξάγει από το myschool, από την αναφορά "Κατάσταση βαθμολογίας για χειρόγραφη ενημέρωση", με τις καταστάσεις βαθμολογίας για μια ολόκληρη τάξη.
3. Συμπληρώστε τις διευθύνσεις των κελιών "Τμήμα", "Τάξη", "Διδάσκοντες".
4. Συμπληρώστε προαιρετικό password για τα κλειδωμένα κελιά στο φύλλο Excel για τους διδάσκοντες.
5. Επιλέξτε αν θα δημιουργηθεί ένα αρχείο ανά διδάσκοντα, με όλα του τα μαθήματα (λιγότερα αρχεία αλλά πολλοί ξεχνούν να συμπληρώσουν όλα τα φύλλα) ή ένα αρχείο ανά μάθημα, ανεξάρτητα από διδάσκοντες.
6. Επιλέξτε αν θα δημιουργηθούν φάκελοι ανά διδάσκοντα για την διευκόλυνση του εντοπισμού των καταστάσεων.
7. Εάν το σχολείο είναι ΕΠΑΛ, επιλέξτε ένα αρχείο Excel με 3 στήλες (Διδάσκοντες, Τμήμα, Μάθημα) που σας έχει δώσει το ΕΚ, με τις αναθέσεις των μαθημάτων του ΕΚ.
8. Πατήστε "Εκκίνηση" για να παραχθούν τα ξεχωριστά αρχεία.
9. Μόλις οι καθηγητές συμπληρώσουν τις βαθμολογίες, επιλέξτε τα αρχεία τους, ρίξτε τα με το ποντίκι στη λίστα "Δημιουργία συγκεντρωτικής κατάστασης" και πατήστε "Εκκίνηση". Θα δημιουργηθεί το αρχείο .xls που έχετε επιλέξει στο σχετικό πεδίο.
10. Το τελικό αρχείο μπορεί να εισαχθεί στο myschool.sch.gr, από την επιλογή "Εισαγωγή βαθμών για όλα τα Μαθήματα μαζικά από αρχείο Excel".

---

# Split and Merge Excel Spreadsheets for myschool.sch.gr

## 📝 Description

This VB.NET application allows the creation of separate Excel files for teachers to enter student grades and later merges them into a single file for bulk import into myschool.sch.gr, Greece's school administration IT system.

The tool simplifies the process of distributing grade sheets to teachers and collecting them for administrative use, reducing errors and saving time.

## ⚙️ Features

- Generates separate Excel files for each teacher, class, and subject.
- Merges multiple Excel files into a single file per class for import into myschool.sch.gr.

## 🚀 How to Use

1. Fill in the fields "Μάθημα", "Αρ. Μητρώου" and "Βαθμοί" ("Subject", "Student ID", and "Grades") with the corresponding addresses in the grade sheets.
2. Select as input the .xlsx Excel sheet exported from myschool, using the "Κατάσταση βαθμολογίας για χειρόγραφη ενημέρωση" (Grade Sheet for Manual Update) report, containing grade sheets for an entire class.
3. Fill in the cell addresses for "Τμήμα", "Τάξη", "Διδάσκοντες" ("Section", "Class", and "Teachers").
4. Optionally, set a password for the locked cells in the teachers' Excel sheets.
5. Choose whether to create one file per teacher with all their subjects (fewer files but a higher chance of missing entries) or one file per subject, independent of the teachers.
6. Choose whether to create folders per teacher for easier file organization.
7. If the school is a vocational school (EPAL), select an Excel file with three columns ((Διδάσκοντες, Τμήμα, Μάθημα, ie Teachers, Section, Subject) provided by the vocational training center (EK), listing the subject assignments.
8. Click "Εκκίνηση" (Start) to generate the individual files.
9. Once the teachers complete the grade entry, select their files, drag them into the "Δημιουργία συγκεντρωτικής κατάστασης" (Create Consolidated Report) list, and click "Εκκίνηση" (Start). The .xls file will be generated at the selected location.
10. The final file can be imported into myschool.sch.gr using the "Εισαγωγή βαθμών για όλα τα Μαθήματα μαζικά από αρχείο Excel" (Bulk Import Grades for All Subjects from Excel File) option.
