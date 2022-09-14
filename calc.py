import re
from decimal import *


def check_precedence(i):
    if i == '*':
        return 2
    if i == '/':
    	return 2
    if i == '+':
        return 1
    if i == '-':
    	return 1
    if i == '(':
    	return 0


def to_postfix(expression):
    queue = []
    op_stack = []
    for i in expression:
        if i not in ('-', '+', '*', '/', '(', ')'):
            queue.append(i)
        elif i == "(":
            op_stack.append(i)
        elif i == ")":
            while op_stack[-1] != "(":
                last = op_stack.pop()
                queue.append(last)
            op_stack.pop()
        elif i in ('+', '-', '/', '*'):
            while op_stack and check_precedence(op_stack[-1]) >= check_precedence(i) and op_stack[-1] != "(":
                queue.append(op_stack.pop())
            op_stack.append(i)
    while op_stack:
        queue.append(op_stack.pop())
    return queue


def calc(postfix):
    stack = []
    for value in postfix:
        if value in ['-', '+', '*', '/']:
            op1 = stack.pop()
            op2 = stack.pop()
            if value == '-':
                stack.append(op2 - op1)
            if value == '+':
                stack.append(op2 + op1)
            if value == '*':
                stack.append(op2 * op1)
            if value == '/':
                stack.append(op2 / op1)
        else:
            stack.append(Decimal(value))
    return stack.pop()


formula = input('> ')
tokenized_formula = re.findall(r"[\d.]+|[()+\-*/]", formula)
postfix_expression = to_postfix(tokenized_formula)
print(calc(postfix_expression))
