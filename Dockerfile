FROM mysql:5.7.22
EXPOSE 3306

COPY APIPag24horas/db/backup.sql /docker-entrypoint-initdb.d/backup.sql
