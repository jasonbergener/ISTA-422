#### MSSA Cohort 3
#### Course: ISTA-422
#### Chapter: 03
#### Name: Jason Bergener
#### Date: December 6, 2017

1.	What is Azure Virtual Machines and the terminology used in the chapter to reference?  
**Azure Virtual Machines supports the deployment of Windows or Linux virtual machines (VMs) in a Microsoft Azure datacenter. You have total control over the configuration of the VM. You are responsible for all server software installation, configuration, and maintenance and for operating system patches./ feature and the instance.**
1. How do you stop an Azure VM, and give an example?  
**To stop a VM but keep it provisioned, you would need to use the Stop-AzureRmVM PowerShell cmdlet.**
    ```powershell
    /Stop-AzureRmVM -Name "AzEssentialDev3" -ResourceGroup "AzureEssentials" -StayProvisioned
    ```
1. What are three main resource providers used when working with Azure Virtual Machines, Storage, and Compute?  
    - **The Network resource provider (Microsoft.Network) handles all aspects of network connectivity such as IP addresses, load balancers, NICs, and so on.**
    - **The Storage resource provider (Microsoft.Storage) handles the storage of the disks for a VM (in the context of Azure Virtual Machines).**
    - **The Compute resource provider (Microsoft.Compute) handles details related to the VM itself, such as naming, operating system details, and configuration (size, number of disks, and so on).**
1. Where are durable disks stored and what are the benefits?  
**All durable disks (the OS disk and data disks) are backed by page blobs in Azure Storage. Therefore, the disks inherit the benefits of blob storage: high availability, durability, and geo-redundancy options. Blob storage provides a mechanism by which data can be stored safely for use by the VM. The disks can be mounted as drives on the VM. The Azure platform will hold an infinite lease on the page blob to prevent accidental deletion of the page blob containing the VHD, the related container, or the storage account.**
1. What is required when creating a VM in Azure using the Resource Manager model?  
**It is required that the VM be placed within an Azure Virtual Network (VNET) when creating a VM in Azure using the Resource Manager model.**
1. What is a NIC and what does it what does it do for Azure?  
**A network interface card (NIC) provides network access to resources in an Azure virtual network. A NIC is a standalone resource, but it must be associated with a VM to provide network access (a NIC by itself is of little value).**
1. Why should you deploy at least two instances of the VM? What is provided?  
**To avoid a single point of failure. Azure provides an SLA only when two or more VMs are deployed into an availability set. This is a logical feature used to ensure that a group of related VMs are deployed so that they are not all subject to a single point of failure and not all upgraded at the same time during a host operating system upgrade in the datacenter.**
1. How many ways can you connect to your VM, and what are they?  
**Connectivity can be done by remotely accessing (for example, logging in remotely to) the VM for an interactive session or by configuring network access to allow other programs or services to communicate with the VM.**
1. Who's responsibility is it to manage the VM?  
**The overall management of the VMs is largely the user’s responsibility.**
1. What is important when determining the scale-out approach to VMs, and what model is this referred to?  
**In the classic model, before VMs can be scaled (out or in), the instances must be placed within an availability set. When determining the scale-out approach for VMs, it is important to determine the maximum number of VMs because that maximum number of VMs must be created, configured, and placed into the availability set.**