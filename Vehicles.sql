CREATE DATABASE Vehicles

use Vehicles
CREATE TABLE VehiclesTable(
	v_id int primary key identity not null,
	PlateNo varchar(50),
	VehicleType varchar(50),
	VehicleBrand varchar(50)
	);