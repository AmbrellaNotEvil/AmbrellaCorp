section .data
	num1 db 4
	num2 db 4
	newline db 0xA

section .bss
	result resb 8

section .text

global _start

_start:
	mov al, [num1]
	add al, [num2]
	add al, '0'
	mov [result], al

	mov rax, 1
	mov rdi, 1
	mov rsi, result
	mov rdx, 1
	syscall

	mov rax, 1
	mov rdi, 1
	mov rsi, newline
	mov rdx, 1
	syscall

	mov rax, 60
	xor rdi, rdi
	syscall


