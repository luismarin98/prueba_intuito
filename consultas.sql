use `prueba_intuito`;
/*
insert into `prueba_intuito`.entidad_pelicula values (1, 'Gozzilla vs Kong', 'Ciencia Ficcion', 16, '2023-10-30 02:25:00'), (2, 'La monja', 'HORROR', 16, '2023-10-30 02:25:00');
insert into `prueba_intuito`.entidad_sala values (1, 'SALA 1', 1), (2, 'SALA 2', 2), (3, 'SALA 3', 3);
insert into `prueba_intuito`.entidad_asiento values (1, 1, 1, 1), (2, 2, 1, 1), (3, 3, 1, 1), (4, 4, 1, 1);
insert into `prueba_intuito`.entidad_cartelera values (1, '2023-10-30 00:00:00', '2023-10-30 00:00:00', '2023-10-30 02:25:00', 1, 1);
insert into `prueba_intuito`.entidad_reserva values (1, '2023-10-30 00:00:00', 2, 1, 4);*/

select * from `prueba_intuito`.entidad_asiento;       
select * from `prueba_intuito`.entidad_pelicula;
select * from `prueba_intuito`.entidad_sala;
select * from `prueba_intuito`.entidad_cliente;
select * from `prueba_intuito`.entidad_cartelera;
select * from `prueba_intuito`.entidad_reserva;

SELECT
  entidad_reserva.id_reserva,
  entidad_reserva.`date`,
  entidad_reserva.id_cliente,
  entidad_reserva.id_asiento,
  entidad_reserva.id_cartelera,
  entidad_pelicula.`Nombre`,
  entidad_pelicula.genero
FROM entidad_reserva
INNER JOIN entidad_pelicula ON entidad_pelicula.id_pelicula
WHERE entidad_pelicula.genero = 'HORROR'
AND entidad_reserva.`date` BETWEEN '2023-10-30' AND '2023-10-30';

SELECT
  entidad_asiento.`Number`,
  entidad_asiento.`RowNumber`,
  COUNT(entidad_reserva.id_reserva) AS asientos_ocupados
FROM entidad_asiento
LEFT JOIN entidad_reserva
ON entidad_asiento.id_asiento = entidad_reserva.id_asiento
WHERE entidad_reserva.`Date` = CURRENT_DATE
GROUP BY entidad_asiento.`Number`, entidad_asiento.`RowNumber`;