import csv
import json
import time

class SchoolBase:
    def __init__(self, file_path):
        self.file_path = file_path
        self.students = []
        self.teachers = {}
        self.load_data()
        
    def load_data(self):
        # завантаження даних з файлу
        
        with open(self.file_path, "r") as md: #відкриваємо файл
            reader = csv.reader(md) #читаємо 
            
            for row in reader: # проходимось по кожному рядку в тексті
                
                if len(row) !=7: #перевіряємо чи рядок має достаньо для нас даних
                    print("некоректний формат файлу")
                    exit(1)
                
                # словник іменованих values, атрибутів, приєднування до них елементів з рядка з інформацією про кожного студента
                student = {"StLastName": row[0], "StFirstName": row[1], "Grade": int(row[2]), "Classroom": int(row[3]), "Bus": int(row[4]), "TLastName": row[5], "TFirstname": row[6]}
            
                # додавання до списку загальну інформацію про студентів. завантажені всі дані з txt
                self.students.append(student)
                
                teacher_key = (row[5], row[6]) # ключ викладача з його ім'ям та прізвищем
                
                if teacher_key not in self.teachers:
                    # якщо викладача ще немає в списку, додаємо
                    self.teachers[teacher_key] = []
                
                # приєднуємо до кожного викладача студентів
                self.teachers[teacher_key].append(student)
                    
    def search_by_student(self, last_name):
        #пошук студентів за прізвищем
        
        results = [s for s in self.students if s["StLastName"].lower() == last_name.lower()]
        
        if results:
            print(f"Студенти з прізвищем {last_name}")
            for student in results:
                print(f"{student["StLastName"]} {student["StFirstName"]} є вихованцем {student["TLastName"]} {student["TFirstname"]} у класі {student["Classroom"]}")
        else:
            print("За таким прізвищем студента не знайдено")       
        
    def search_by_student_bus(self, last_name):
        # за прізвищем студента автобусний маршрут
            
    def search_by_teacher(self, last_name):
        # за прізвищем викладачач його студентів
            
    def search_by_classroom(self, classroom):
        # за класом студентів
            
    def search_by_bus_route(self, bus_route):
        # за автобусним маршрутом студентів

file_path = 'students.txt'
database = SchoolBase(file_path)
    
while True:
    print("\nОпції: \n S[tudent]: <lastname> BUS \n S[tudent]: <lastname> \n T[eacher]: <lastname> \n C[lassroom]: <number> \n B[us]: <number> \n Q[uit]")
    choise = input("Виберіть команду: ").strip()
        
    start_time = time.time()
        
    if choise.lower().startswith("s"):
        if "bus" in choise.lower():
            # пошук за прізвищем студента автобусний маршрут
            last_name = choise.split()[1]
            database.search_by_student_bus(last_name)
        else:
            # пошук інформації про студента за прізвищем
            last_name = choise.split()[1]
            database.search_by_student(last_name)
                
    # ....................
        
    else:
        print("Недійсна команда")
      
        
    elapsed_time = time.time() - start_time
        
    print(f"Час пошуку {elapsed_time} секунд")
            
        
        