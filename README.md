# Aperi-backend

## Setup
To set up the migrations for the database, follow these steps:

1. Use the 
```
add-migration <migration-name>
```
command in the Package manager console in your IDE.

2. After that, build the database with the
```
update-database 
```
command also in your IDE's Package manager console.

## Conventions

### General conventions:
- everything in **English**
- indentation: **4 spaces**, not tabs
- max line length: **80**
- comments/documentation max line length: **70**
---
### Naming conventions:
- function/method names are **verbs**
- boolean variables starts with **isX** or **hasX**
- pronounceable names (**addUser**, not addUsr)
- explain ambiguous name or abbreviation in a comment above the name
- comments **above** the variable/method
- flag comments (could be put in the line other than directly above variable/method) without a message:
	- ***TODO***
	- ***FIXME***
- flag comments with a message:
	- ***TODO: message***
	- ***FIXME: message***
- comments **only** when use case not understandable from variable/method name
	- // this is a comment
	- //this ain't a comment
- multiline comments like:
	- // first line
	- // second line
	- why:
		- /* */ - comments are reserved for "doc comments"
- [Allman Parentheses](https://en.wikipedia.org/wiki/Indentation_style#Allman_style) for everything (loops, conditionals, try/catch...)
- **classes** in PascalCase
- **components** in PascalCase
- **constants** in UPPER_CASE
- everything other in **camelCase**
- private **_fields**
- file names in **snake_case**
---

### Git conventions:
- commit messages in **imperative**
- commit messages starting with a **lowercase** letter
- [commit message standars](https://gist.github.com/tonibardina/9290fbc7d605b4f86919426e614fe692)
- linking **"AB#nn"** in a **new line** in a commit message
- **no** commit message ends with a period, question or exclamation mark
- workflow: [**gitflow**](https://www.atlassian.com/git/tutorials/comparing-workflows/gitflow-workflow)
---

### Database conventions:
- table names using **snake_case**; lowercase
- column names using **snake_case**; lowercase

---
