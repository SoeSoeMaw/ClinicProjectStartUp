   M S B A M L   `   `   `  ����  ClinicProjectStartUp2    ,ClinicProjectStartUp.Views.PatientListFilter   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v17.2, Version=17.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  5      -   5          � Title$  Patient Filter Box��5      $	��350��5      $	��525��5       � 
ResizeMode$ NoResize=�5       � WindowStartupLocation$ CenterScreen=�5	      .��5      �  � RowDefinitions 5   
   �� 5      $��30 �6   6*   �� 5      $��40 �6   6*   �� 5      $��40 �6   6*   �� 5      $��40 �6   6*   �� 5      $��30 �6   6*   �� 5      $��30 �6   6*    � ColumnDefinitions 5   
   �� 5      $��143.2 �6   6/   �� 5      $��264.8 �6   6/   .+�5   
   �� $$��Select Patient's List Filters:��6   $��0��5      $��0��5      $��2��5      $��0,3.6,6,3.6q�5      $��14(�5      $
��Bold"�5      $��
Zawgyi-One)�5       �� 5!   
   $��FROM DATE :��6   $��1��5"      $��0��5#      $��0,3.6,6,3.6q�5$      (  "System.Windows.Controls.DatePicker  5%   
   -   5        $��dtpFromDate��5%      $��1��5&      $	��300��5'      $
��Left=�5(      $��0,3.6,-34.4,3.6q�5)      $��1��5*      �� 5,   
   $��	TO DATE :��6   $��2��5-      $��0��5.      $��0,3.4,6,2.8q�5/        50   
   -   5        $��	dtpToDate��50      $��2��51      $	��300��52      $
��Left=�53      $��0,3.4,-34.4,2.8q�54      $��1��55      �� 56   
   $��Select Patient's Status :��6   $��3��57      $��0��58       J� RenderTransformOrigin$ 0.421,1.842&�59      $��
1,3.2,27,3q�5:      �� 5;   
   -   5         ��Name$ combo_patient_type��5=      $��1��5;      $��3��5<       �� SelectedIndex$ 0��5>       �� 
IsEditable . $	��300��5@      $��30��5A      $��0,3.4,-34.4,2.8q�5B      $	��Top=�5C      6-   �� 5D   
   -   5        $��btnFilterPatient��5D      $��Filter��5E      $��1��5F      $��4��5G      $	��100��5H      $��Right=�5I      $��0,3.4,-34.4,2.8q�5J      5K      5M      5N      