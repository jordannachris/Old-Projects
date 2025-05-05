SELECT *
FROM departments;

SELECT department_id, location_id
FROM departments;

SELECT last_name, salary
FROM employees;

SELECT last_name, salary + 300
FROM employees;

SELECT last_name, job_id, salary, commission_pct
FROM employees;

SELECT last_name, job_id, 12*salary*commission_pct
FROM employees;

SELECT last_name, job_id, salary, commission_pct
FROM employees
WHERE commission_pct IS NULL;

SELECT last_name, job_id, salary, commission_pct
FROM employees
WHERE commission_pct IS NOT NULL;

SELECT last_name AS name, commission_pct AS comm
FROM employees;

SELECT last_name AS "Name", salary * 12 AS "Annual Salary"
FROM employees;