## Running Oracle-XE from a docker image

### Option 1 - Docker run command

docker run -d --name oracle-xe \
  -p 1521:1521 \
  -p 8080:8080 \
  -e ORACLE_PASSWORD=oracle \
  gvenzl/oracle-xe

### Option 2 - Run docker-compose

## Connect to Oracle via SQL*Plus

docker exec -it oracle-xe sqlplus system/oracle@XEPDB1

user-name: system
password: oracle

### Create Table Example

CREATE TABLE employees (
  emp_id    NUMBER PRIMARY KEY,
  emp_name  VARCHAR2(50),
  salary    NUMBER
);


### Create Procedure Example

CREATE OR REPLACE PROCEDURE add_employee (
  p_emp_id   IN NUMBER,
  p_emp_name IN VARCHAR2,
  p_salary   IN NUMBER
)
IS
BEGIN
  -- Start of Transaction
  IF p_salary < 0 THEN
    RAISE_APPLICATION_ERROR(-20001, 'Salary must be non-negative.');
  END IF;

  INSERT INTO employees (emp_id, emp_name, salary)
  VALUES (p_emp_id, p_emp_name, p_salary);

  COMMIT; -- Commit if no exception

EXCEPTION
  WHEN OTHERS THEN
    ROLLBACK;
    DBMS_OUTPUT.PUT_LINE('Error: ' || SQLERRM);
    -- Optionally re-raise the error
    -- RAISE;
END;
/

### Enable DBMS_OUTPUT

SET SERVEROUTPUT ON


### Add employees via stored procedure

EXEC add_employee(101, 'Droyte', 50000);

EXEC add_employee(102, 'Michael', -100);        


### Execution Plan

# store execution plan for query

EXPLAIN PLAN FOR
SELECT * FROM employees WHERE emp_id = 101;

# view the plan
SELECT * FROM TABLE(DBMS_XPLAN.DISPLAY);

# example performance tuning index operations

INDEX UNIQUE SCAN -> Fastest
INDEX RANGE SCAN -> Efficient
INDEX SKIP SCAN -> Good
