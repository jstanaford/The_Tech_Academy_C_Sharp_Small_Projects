

USE db_zooTest2

/* DRILL 1*/
SELECT * FROM tbl_habitat

/* DRILL 2 */
SELECT species_name, species_order FROM tbl_species WHERE species_order = 3;

/* DRILL 3 */
SELECT nutrition_type, nutrition_cost FROM tbl_nutrition WHERE nutrition_cost <= 600.00;

/* DRILL 4 */

SELECT species_name, species_nutrition
FROM tbl_species
INNER JOIN tbl_nutrition
ON tbl_species.species_nutrition = tbl_nutrition.nutrition_id
WHERE species_nutrition BETWEEN 2202 AND 2206;

/* DRILL 5 */

SELECT species_name AS 'Species Name:', nutrition_type AS 'Nutrition Type:'
FROM tbl_species
INNER JOIN tbl_nutrition
ON tbl_species.species_nutrition = tbl_nutrition.nutrition_id;

/* DRILL 6 */

SELECT specialist_fname, specialist_lname, specialist_contact
FROM tbl_specialist 
INNER JOIN tbl_species
ON tbl_specialist.specialist_id = tbl_species.species_id
WHERE species_name = 'penguin';

/* DRILL 7 */

CREATE DATABASE db_drill7;

USE db_drill7;


CREATE TABLE tbl_contact (
	Contact_ID VARCHAR(50) NOT NULL PRIMARY KEY,
	person_phone VARCHAR(50) NOT NULL,
	person_address VARCHAR(50) NOT NULL,
	);

CREATE TABLE tbl_name (
	Name_ID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	person_fname VARCHAR(50) NOT NULL,
	person_lname VARCHAR(50) NOT NULL,
	person_contact VARCHAR(50) NOT NULL CONSTRAINT fk_Contact_ID FOREIGN KEY REFERENCES tbl_contact(Contact_ID) ON UPDATE CASCADE ON DELETE CASCADE
	);


INSERT INTO tbl_contact
	(Contact_ID, person_phone, person_address)
	VALUES
	('Person_1', '1800-thenorth', ' 1 Winterfell Ave'),
	('Person_2', '717-wealwayspayourdebts', '777 CasterlyRock')
;


INSERT INTO tbl_name
	(person_fname, person_lname, person_contact)
	VALUES
	( 'Ned', 'Stark', 'Person_1'),
	('Jamie', 'Lannister', 'Person_2')
;

SELECT person_fname, person_contact
FROM tbl_name
INNER JOIN tbl_contact
ON tbl_name.person_contact = tbl_contact.Contact_ID
WHERE person_contact = 'Person_1';


