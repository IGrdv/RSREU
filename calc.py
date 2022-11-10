import re
from decimal import *


def precedence_of(i):
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
    operator_stack = []
    for current_token in expression:
        if current_token not in ('-', '+', '*', '/', '(', ')'):
            queue.append(current_token)
        elif current_token == "(":
            operator_stack.append(current_token)
        elif current_token == ")":
            while operator_stack[-1] != "(":
                last = operator_stack.pop()
                queue.append(last)
                if not operator_stack:
                    print('Mismatched parentheses.')
                    exit(1)
            operator_stack.pop()
        elif current_token in ('+', '-', '/', '*'):
            while True:
                if not operator_stack:
                    break
                top_stack_operator = operator_stack[-1]
                if top_stack_operator == "(":
                    break
                if precedence_of(top_stack_operator) < precedence_of(current_token):
                    break
                queue.append(operator_stack.pop())
            operator_stack.append(current_token)
    while operator_stack:
        queue.append(operator_stack.pop())
    return queue


def calc(postfix):
    stack = []
    for value in postfix:
        if value in ['-', '+', '*', '/']:
            op1 = stack.pop()
            try:
                op2 = stack.pop()
            except IndexError:
                print('Invalid expression.')
                exit(1)
            if value == '-':
                stack.append(op2 - op1)
            if value == '+':
                stack.append(op2 + op1)
            if value == '*':
                stack.append(op2 * op1)
            if value == '/':
                if op1 == 0:
                    print('Division by zero')
                    exit(1)
                stack.append(op2 / op1)
        else:
            try:
                stack.append(Decimal(value))
            except InvalidOperation:
                print('Invalid expression.')
                exit(1)
    return stack.pop()


def calculate():
    formula = input('> ')
    tokenized_formula = re.findall(r"[\d.]+|[()+\-*/]", formula)
    operands_amount = 0
    operators_amount = 0
    for token in tokenized_formula:
        if token in ('-', '+', '*', '/'):
            operators_amount += 1
        if token.replace('.', '', 1).isdigit():
            operands_amount += 1

    if operators_amount < operands_amount - 1:
        print('Not enough operators.')
    elif operands_amount - 1 < operators_amount:
        print('Too many operators.')
    else:
        postfix_expression = to_postfix(tokenized_formula)
        print(calc(postfix_expression))


while True:
    calculate()
