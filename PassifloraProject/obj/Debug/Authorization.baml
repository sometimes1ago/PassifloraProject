   M S B A M L   `   `   `  ����L  HPassifloraProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:PassifloraProjectPassifloraProject  5   	   %    PassifloraProject.Authorization   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:PassifloraProject     5   	   -   5          � Title$  Авторизация��5   	   $	��720��6   $
��1366��6*   $	��720��5	   	   $
��1366��6    � 
ResizeMode$ NoResize=�6)    � WindowStartupLocation$ CenterScreen=�6?   ���#F0F6FF.��5
      �  � ColumnDefinitions 5   
   �� 5      $	��195 �6   �� 5      $	��195 �6   �� 5      $	��195 �6   �� 5      $	��195 �6   �� 5      $	��195 �6   �� 5      $	��195 �6   �� 5      $	��195 �6    � RowDefinitions 5   
   �� 5      $��99 �6   �� 5      $��99 �6   �� 5      $��99 �6   �� 5      $��99 �6   �� 5      $��99 �6   �� 5      $��99 �6   �� 5      $��99 �6   .+�5   
   �� $
��Left=�6   $	��536��6+   $��6��68   $	��Top=�6I   $	��429��6a   $*��$Images/AuthRegister/AuthLeftSide.png��6m   $��3��6�   �� 5   
   $��3��6   $��4��6$   $
��Left=�64   $	��629��6O   $��	109,0,0,0q�6\   $��7��6o   $	��Top=�6�   $	��471��6�   $+��%Images/AuthRegister/AuthRightSide.png��6�   �� 5   
   $��2��6   $��Center=�6%   $	��539��6B   $��
60,80,60,0q�6O   $	��Top=�6c   $	��465��6{   $��3��6�   $��7��6�   .+�5       �� -   5         ��Name$ 
MainHeader��5       $��2��6,   $��Center=�6<    �� TextAlignment$ Center=�6Y   $��0,0,0,0q�6p   $
��Wrap=�6�   $7��1Авторизация пользователей��6�   $	��Top=�6�   $4��./PassifloraProject;component/Fonts/#El Messiri)�6�   $��68(�6
   �� 
LineHeight$ 82��5!       �� LineStackingStrategy$ BlockLineHeight=�6$   $��3��6K   $��3��6_   $	��468��6p   ���	#FF1B5B426|   �� 5"      $��Center=�6   $��94��66   $��0,25,0,0q�6B   $	��Top=�6T   $	��350��6l   .+�5#      �� $4��./PassifloraProject;component/Fonts/#El Messiri)�6   ���	#FF1B5B42$��Center=�6o   $��0,0,0,0q�6�   $
��Wrap=�6�   $��
Логин��6�   $��22(�6�   $	��Top=�6�   �� 5$      -   5        	 ��Name$	 
LoginInput��5$      $
��Left=�6.   $��50��6I   
 �� TextWrapping$

 Wrap=�6U   $	��Top=�6i   $��350px��6�      RoundedTextBoxAuth#���   6�   $��0,10,0,0q�6�   5%      �� 5&      $��Center=�6   $	��100��66   $��0,15,0,0q�6C   $	��Top=�6U   $	��350��6m   .+�5'      �� $4��./PassifloraProject;component/Fonts/#El Messiri)�6   ���	#FF1B5B42$��Center=�6p   $��0,0,0,0q�6�   $
��Wrap=�6�   $��Пароль��6�   $��22(�6�   $	��Top=�6�   $��74��6�   G� 5(      -   5         G�Name$ PasswordInput��5(      $��Center=�65   $��50��6R   $	��Top=�6^   $��350px��6v   $��0,10,0,0q�6�     PasswordBox#���  6�   5)      �� 5*      -   5         ��Name$ 
AuthButton��5*      $��Black"�6)   $��
Войти��6U   $4��./PassifloraProject;component/Fonts/#Montserrat)�6e   $��Center=�6�   $��0,20,0,0q�6�   $	��Top=�6�   $	��350��6�   $��50��6�   $��16(�6   ���	#FF1B5B42
�������6%  �� 5+      -   5        $ RegisterLink��5+      $
��14px(�6a   $��Center=�6q   $��0,15,0,0q�6�   $
��Wrap=�6�   $)��#Нет учетной записи?��6�   $	��Top=�6�   $4��./PassifloraProject;component/Fonts/#Montserrat)�6�   $	��154��6#  �� 5,      -   5         ��Name$ BackControl��5,      $��Center=�6`   $��17��6}   $��192,15,189,0q�6�   $	��Top=�6�   $��84��6�   .+�5-      �� -   5        $ BackLink��5-      $
��Left=�6.   $��	40,0,-5,0q�6I   $��6��6\   $
��Wrap=�6i   $��
Назад��6}   $	��Top=�6�   $4��./PassifloraProject;component/Fonts/#Montserrat)�6�   $��14(�6�   $��45��6�   �� 5.      $
��Left=�6   $��	0,-12,0,0q�63   $	��Top=�6F   $'��!Images/AuthRegister/BackArrow.png��6^   $��35��6�   5/      51      53      54      