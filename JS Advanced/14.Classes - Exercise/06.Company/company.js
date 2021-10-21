class Company {
    constructor(){
        this.departments = {};
    }

    addEmployee(name, salary, position, department){
        if (!name || !salary || !position || !department || salary < 0 ) {
            throw new Error('Invalid input!')
        }
        let employee = {name, salary, position};
        if (!this.departments[department]) {
            this.departments[department] = [];
        }
        this.departments[department].push(employee);
        return `New employee is hired. Name: ${name}. Position: ${position}`;
    }

    bestDepartment(){
        let best = {
            name: '',
            avgSalary:  0,
            employyes: []
        }
        for (const dep in this.departments) {
            let currentDepSalary = 0;
            let count = 0;
            for (const emp in this.departments[dep]) {
                currentDepSalary += Number(this.departments[dep][emp].salary);
                count ++;

            }
            let avgSalary = currentDepSalary / count
            if (best.avgSalary < avgSalary) {
                best.name = dep
                best.avgSalary = avgSalary
                let currentDepEmployees = this.departments[dep].sort((a, b) => {
                    return b.salary - a.salary || a.name.localeCompare(b.name);
                })
                best.employyes = currentDepEmployees
            }
        }
        let result = '';
        result += `Best Department is: ${best.name}\n`
        result += `Average salary: ${best.avgSalary.toFixed(2)}\n`
        for (const employee of best.employyes) {
            result += `${employee.name} ${employee.salary} ${employee.position}\n`
        }
        return result.trim();

        
    }
}
let c = new Company();
c.addEmployee("Stanimir", 2000 ,"engineer", "Construction");
c.addEmployee("Pesho", 1500, "electrical engineer", "Construction");
c.addEmployee("Slavi", 500, "dyer", "Construction");
c.addEmployee("Stan", 2000, "architect", "Construction");
c.addEmployee("Stanimir", 1200, "digital marketing manager", "Marketing");
c.addEmployee("Pesho", 1000, "graphical designer", "Marketing");
c.addEmployee("Gosho", 1350, "HR", "Human resources");
console.log(c.bestDepartment());

