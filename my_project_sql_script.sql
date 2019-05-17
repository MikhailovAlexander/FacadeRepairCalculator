create database facade_calculator;

psql facade_calculator;

CREATE TABLE application_user (
	id serial NOT NULL,
	name VARCHAR(255) NOT NULL UNIQUE,
	passport VARCHAR(255) NOT NULL UNIQUE,
	login VARCHAR(255) NOT NULL UNIQUE,
	hash_password VARCHAR(255) UNIQUE,
	manager_access BOOLEAN NOT NULL DEFAULT 'false',
	salt_string VARCHAR(255),
	CONSTRAINT user_pk PRIMARY KEY (id)
) WITH (
  OIDS=FALSE
);

CREATE TABLE client (
	id serial NOT NULL,
	name VARCHAR(255) NOT NULL UNIQUE,
	address VARCHAR(255) NOT NULL,
	inn VARCHAR(255) NOT NULL UNIQUE,
	CONSTRAINT client_pk PRIMARY KEY (id)
) WITH (
  OIDS=FALSE
);

CREATE TABLE project (
	id serial NOT NULL,
	name VARCHAR(255) NOT NULL UNIQUE,
	address VARCHAR(255) NOT NULL,
	id_client integer NOT NULL,
	id_project_state integer NOT NULL,
	date_of_start DATE,
	date_of_complete DATE,
	planned_date_of_complete DATE,
	CONSTRAINT project_pk PRIMARY KEY (id)
) WITH (
  OIDS=FALSE
);

ALTER TABLE project ADD CONSTRAINT project_fk0 FOREIGN KEY (id_client) REFERENCES client(id);

CREATE TABLE user_in_project (
	id serial NOT NULL,
	id_user integer NOT NULL,
	id_project integer NOT NULL,
	CONSTRAINT user_in__pk PRIMARY KEY (id)
) WITH (
  OIDS=FALSE
);

ALTER TABLE user_in_project ADD CONSTRAINT user_in_project_fk0 FOREIGN KEY (id_user) 
REFERENCES application_user(id);
ALTER TABLE user_in_project ADD CONSTRAINT user_in_project_fk1 FOREIGN KEY (id_project) 
REFERENCES project(id);

create unique index i_user_in_project_unique
on user_in_project (id_user, id_project);

create table type_of_work(
	id serial not null,
	name varchar(255) unique not null,
	measure_unit varchar(255) not null,
	id_dimension integer not null,
	constraint type_o_w_pk primary key (id)
) with (oids=false);

create table work_in_project(
	id serial not null,
	id_project integer not null,
	id_type_of_work integer not null,
	price numeric not null,
	multiplicity numeric not null,
	constraint work_i_p_pk primary key (id)
) with (oids=false);

	
alter table work_in_project add constraint work_in_project_fk0 foreign key (id_project)
	references project(id);
alter table work_in_project add constraint work_in_project_fk1 foreign key (id_type_of_work)
	references type_of_work(id);
	
create unique index i_work_in_project_unique 
on work_in_project (id_project, id_type_of_work);

create table payment(
	id serial not null,
	id_user integer not null,
	id_project integer not null,
	date_of_payment date not null,
	amount numeric not null,
	constraint payment_pk primary key (id)
) with (oids=false);

ALTER TABLE payment ADD CONSTRAINT payment_fk0 FOREIGN KEY (id_user) 
REFERENCES application_user(id);
ALTER TABLE payment ADD CONSTRAINT payment_fk1 FOREIGN KEY (id_project) 
REFERENCES project(id);

create table element_picture(
	id serial not null,
	name varchar(255) unique not null,
	picture bytea not null,
	constraint element_picture_pk primary key (id)
) with (oids=false);

create table type_of_element(
	id serial not null,
	name varchar(255) unique not null,
	id_element_picture integer not null,
	square numeric not null,
	height numeric not null,
	length numeric not null,
	constraint type_of_element_pk primary key (id)
) with (oids=false);

alter table type_of_element add constraint type_of_element_fk0 foreign key (id_element_picture)
	references element_picture(id);
	
create table type_of_element_in_project(
	id serial not null,
	id_type_of_element integer not null,
	id_project integer not null,
	constraint type_of_element_in_project_pk primary key (id)
) with (oids=false);

alter table type_of_element_in_project add constraint type_of_element_in_project_fk0 foreign key (id_type_of_element)
	references type_of_element(id);
alter table type_of_element_in_project add constraint type_of_element_in_project_fk1 foreign key (id_project)
	references project(id);
create unique index i_type_of_element_in_project_unique
	on type_of_element_in_project (id_type_of_element, id_project);
	
create table section_of_building(
	id serial not null,
	name varchar(255) not null,
	id_project integer not null,
	quantity_by_height integer not null,
	quantity_by_width integer not null,
	constraint section_of_building_pk primary key (id)
) with (oids=false);

alter table section_of_building add constraint section_of_building_fk0 foreign key (id_project)
	references project(id);
create unique index i_section_of_building_unique
	on section_of_building (name, id_project);

create table element(
	id serial not null,
	id_section_of_building integer not null,
	id_type_of_element integer,
	ordinal_nubmer_by_height integer not null,
	ordinal_nubmer_by_width integer not null,
	constraint element_pk primary key (id)
) with (oids=false);

alter table element add constraint element_fk0 foreign key (id_section_of_building)
	references section_of_building(id);
alter table element add constraint element_fk1 foreign key (id_type_of_element)
	references type_of_element(id);
create unique index i_element_unique
	on element (id_section_of_building, ordinal_nubmer_by_height, ordinal_nubmer_by_width);
	
create table work_by_element(
	id serial not null,
	id_element integer not null,
	id_work_in_project integer not null,
	id_work_state integer not null,
	multiplicity numeric not null,
	constraint work_by_element_pk primary key (id)
) with (oids=false);

alter table work_by_element add constraint work_by_element_fk0 foreign key (id_element)
	references element(id);
alter table work_by_element add constraint work_by_element_fk1 foreign key (id_work_in_project)
	references work_in_project(id);
create unique index i_work_by_element_unique
	on work_by_element (id_element, id_work_in_project, id_work_state);
	
create table work_log(
	id serial not null,
	id_work_by_element integer not null,
	id_user integer not null,
	id_type_of_log integer not null,
	log_date date not null,
	log_comment varchar(255) not null,
	constraint work_log_pk primary key (id)
) with (oids=false);

alter table work_log add constraint work_log_fk0 foreign key (id_work_by_element)
	references work_by_element(id);
alter table work_log add constraint work_log_fk1 foreign key (id_user)
	references application_user(id);