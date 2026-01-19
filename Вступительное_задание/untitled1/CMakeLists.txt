cmake_minimum_required(VERSION 3.30)
project(untitled1)

set(CMAKE_CXX_STANDARD 20)

# Добавляем исполняемый файл
add_executable(untitled1 main.cpp)

# Подключаем библиотеку Winsock
target_link_libraries(untitled1 Ws2_32)