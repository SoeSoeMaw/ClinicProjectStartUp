   M S B A M L   `   `   `  ����O  KClinicProjectStartUp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:ClinicProjectStartUp.ViewsClinicProjectStartUp.Views  5
      4    .ClinicProjectStartUp.Views.NormaleCustomerView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v17.2, Version=17.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      c _DevExpress.Xpf.Ribbon.v17.2, Version=17.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxr4http://schemas.devexpress.com/winfx/2008/xaml/ribbon  5      <dxb2http://schemas.devexpress.com/winfx/2008/xaml/bars  5      ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  5      c _DevExpress.Xpf.NavBar.v17.2, Version=17.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxn4http://schemas.devexpress.com/winfx/2008/xaml/navbar  5      f bDevExpress.Xpf.Grid.v17.2.Core, Version=17.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aa	 ]DevExpress.Xpf.Grid.v17.2, Version=17.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxg2http://schemas.devexpress.com/winfx/2008/xaml/grid  	 5	      6Views(clr-namespace:ClinicProjectStartUp.Views  	 5
      -   5          � 	Resources  5         TextBoxBaseControlTemplate �� 
TargetType ��Name �� CornerRadius ��Name �� Triggers P� Property P� Value �� Value	 �� 
TargetName
 �� Property��%  &	        �� 5   
   " ��5      .R�5      �� $ Bd��5      #��z��5      
���   �#��z��5      $ 10��5      ._�5      �� $ PART_ContentHost��6   5       5      P� 5       � {� . . �5      �� # � ��5       $	 Bd��5!      
 � ���� 5"      # � ��5#      
 � ��5$      P� 5%       � ��$
 Auto��5&      . �5'      �� 
 � ��$	 180��5(      5)      P� 5*       � ��$
 Auto��5+      . �5,      �� 
 � ��$ 20��5-      5.      50      52      .��54      � .+�56   
   ]� .+�57      )  #DevExpress.Xpf.Ribbon.RibbonControl  $	��Top=�6       RibbonStyle$ 
Office2010=�58          
Categories. 5:      5  /DevExpress.Xpf.Ribbon.RibbonDefaultPageCategory  2  ,DevExpress.Xpf.Ribbon.RibbonPageCategoryBase   Pages. 5;      &   DevExpress.Xpf.Ribbon.RibbonPage     Caption)  #DevExpress.Xpf.Core.ObjectConverter$
 Home 6%      Groups. 5<      +  %DevExpress.Xpf.Ribbon.RibbonPageGroup     Caption$ Patient's Actions List��6.      Items. 5=      '  !DevExpress.Xpf.Bars.BarButtonItem  -   5         �Name$ Create_New_Patient��5>   0   !  DevExpress.Xpf.Bars.BarItem   Content$ Create New Patient 5=   0      Hint$ Create New Patient 5?   0      
LargeGlyph 5@   0   *	  $DevExpress.Xpf.Core.DXImageExtension	   	  Image1
  +DevExpress.Xpf.Core.Native.DXImageConverter$ AddFile_32x32.png
    Glyph 5A   0   	  $ AddFile_16x16.png
 5B   0     5C      -   5        $ Delete_Patient��5D   0   $ Delete Patient 5C   0   $ Delete Patient 5E   0    5F   0   	  $ Trash_16x16.png
  5G   0   	  $ Trash_32x32.png
 5H   0     5I      -   5        $ View_Patient_History��5J   0   $ View Patient History 5I   0   $ View Patient History 5K   0    5L   0   	  $ NewTableStyle_16x16.png
  5M   0   	  $ NewTableStyle_32x32.png
 5N   0     5O      -   5        $ Add_Patient_History��5P   0   $ Add Patient History 5O   0   $ Add Patient History 5Q   0    5R   0   	  $ Insert_16x16.png
  5S   0   	  $ Insert_32x32.png
 5T   0     5U      -   5        $ Confirm_Patient��5V   0   $ Confirm Patient's  5U   0   $ Confirm Patient 5W   0    5X   0   	  $ BONote_16x16.png
  5Y   0   	  $ BONote_32x32.png
 5Z   0     5[      -   5        $ filter_patient��5\   0   $ Filter Patients 5[   0   $ Filter Data 5]   0    5_   0   	  $$ FilterByArgument_Pie_16x16.png
  5`   0   	  $$ FilterByArgument_Pie_32x32.png
   5a      -   5        $ 
Add_Doctor��5b   0   $ Add Doctor Information 5a   0    5c   0   	  $ BOCustomer_32x32.png
  5d   0   	  $ BOCustomer_32x32.png
 5e   0   5f      5h      5i      5j      � 5l       � RowDefinitions 5m      �� 5o      $�� * �6$   62   .+�5v      % 	 DevExpress.Xpf.Grid.GridControl  -	   5          Name$ gc_patient_list��5w   "   $��1��5v   "   )  #DevExpress.Xpf.Grid.DataControlBase   SelectionMode$	 Row=�5x   "   {�.    Columns 5z      $ 	 DevExpress.Xpf.Grid.GridColumn  5{      $  DevExpress.Xpf.Grid.ColumnBase   IsSmart . $  DevExpress.Xpf.Grid.BaseColumn   Header$ 
Patient ID 5|   )      	FieldName$ id��5}   )     5~       . $ Patient Name 5   )   $
 name��5�   )     5�       . $ Address 5�   )   $ address��5�   )     5�       . $	 Age 5�   )   $	 age��5�   )     5�       . $ Marital Status 5�   )   $ m_status��5�   )     5�       . $ Health Status 5�   )   $ health_status��5�   )     5�       . $ Patient's Current Status 5�   )   $ p_status��5�   )     5�       . $ Check Doctor 5�   )   $ 
doctorName��5�   )     5�       . $ Refer By (Doctor Name) 5�   )   $ refer_by_name��5�   )      View 5�      # 	 DevExpress.Xpf.Grid.TableView  5�      -
   5        $��gc_patient_tbl��5�   (   &   DevExpress.Xpf.Grid.DataViewBase    AllowEditing  . !   NewItemRowPosition$	! Top=�5�   (   & 	  DevExpress.Xpf.Grid.GridViewBase"   ShowGroupPanel" .  #   ShowSearchPanelMode$# Always=�5�   (   $   	AutoWidth$ .  !%   ShowCheckBoxSelectorColumn% .  4&   -RetainSelectionOnClickOutsideCheckBoxSelector& .  5�   (   5�      5�      5�      5�      5�      